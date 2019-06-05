using System;

namespace Algorithms_N_Exercises
{
    interface Stream42
    {
        int Read(int[] data);
    }

    class Stream
    {
        const int BufLength = 42;
        Stream42 stream42;
        int[] buffer = null;
        int offsetNotReturned = 42;
        int streamEnd = 0;


        Stream(Stream42 s) => this.stream42 = s;

        // abcd , offset = 2, length = 2
        // data { , ,a,b }
        //
        int Read(int[] data, int offset, int length)
        {
            int bytesToReadMore = length;
            int initialOffset = offset;
            if (buffer != null && offsetNotReturned < BufLength)
            {
                int currBufLength = streamEnd - offsetNotReturned;
                int lengthToCopy = (bytesToReadMore <= currBufLength) ? bytesToReadMore : currBufLength;
                Array.Copy(buffer, offsetNotReturned, data, offset, lengthToCopy);
                bytesToReadMore -= lengthToCopy;
                offset += lengthToCopy;
            }

            bool isStreamEnded = false;

            while (bytesToReadMore > 0 && !isStreamEnded)
            {
                buffer = new int[BufLength];
                int bytesReaded = stream42.Read(buffer);
                streamEnd = bytesReaded;
                offsetNotReturned = 0;
                int lengthToCopy;

                if (bytesToReadMore <= bytesReaded)
                {
                    lengthToCopy = bytesToReadMore;
                    offsetNotReturned += lengthToCopy;
                }
                else
                {
                    if (bytesReaded < BufLength)
                    {
                        lengthToCopy = bytesReaded;
                        isStreamEnded = true;
                    }
                    else
                    {
                        lengthToCopy = BufLength;
                    }
                }
                Array.Copy(buffer, offsetNotReturned, data, offset, lengthToCopy);
                bytesToReadMore -= lengthToCopy;
                offset += lengthToCopy;
            }
            return offset - initialOffset;
        }
    }

}
