using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public interface ITransform
    {
        byte transform(byte ch);

        string GetTransformedString(string input);
    }
    public class Encrypt : ITransform
    {
        const String str = "bcdefghijklmnopqrstuvwxyza";

        public string GetTransformedString(string input)
        {
            string RetVal = string.Empty;

            try
            {
                byte[] inputBytes = Encoding.Default.GetBytes(input);
                List<byte> OpList = new List<byte>();
                foreach (byte b in inputBytes)
                {
                    if (char.IsLower((char)b))
                        OpList.Add((byte)str[b - (byte)'a']);
                    else if (char.IsUpper((char)b))
                        OpList.Add((byte)str[b - (byte)'A']);
                    else
                        OpList.Add(b);
                }

                RetVal = Encoding.Default.GetString(OpList.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RetVal;
        }

        byte ITransform.transform(byte ch)
        {
            if (char.IsLower((char)ch))
                ch = (byte)str[ch - (byte)'a'];
            return ch;
        }


    }
    class Decrypt : ITransform
    {
        const String str = "bcdefghijklmnopqrstuvwxyza";

        public string GetTransformedString(string input)
        {
            string RetVal = string.Empty;

            try
            {
                byte[] inputBytes = Encoding.Default.GetBytes(input);
                List<byte> OpList = new List<byte>();
                foreach (byte b in inputBytes)
                {
                    if (char.IsLower((char)b))
                        OpList.Add((byte)(str.IndexOf((char)b) + 'a'));
                    else if (char.IsUpper((char)b))
                        OpList.Add((byte)(str.IndexOf((char)b) + 'A'));
                    else
                        OpList.Add(b);
                }

                RetVal = Encoding.Default.GetString(OpList.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RetVal;

        }

        byte ITransform.transform(byte ch)
        {
            if (char.IsLower((char)ch))
                ch = (byte)(str.IndexOf((char)ch) + 'a');
            return ch;
        }
    }



    class TransformWriter : Stream, IDisposable
    {
        private Stream outs;
        private ITransform trans;

        public TransformWriter(Stream s, ITransform t)
        {
            this.outs = s;
            this.trans = t;
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override bool CanSeek
        {
            get { return false; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }
        public override void Flush()
        {
            outs.Flush();
        }

        public override long Length
        {
            get { return outs.Length; }
        }
        public override long Position
        {
            get
            {
                return outs.Position;
            }
            set
            {
                outs.Position = value;
            }
        }
        public override long Seek(long offset, SeekOrigin origin)
        {
            return outs.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            outs.SetLength(value);
        }

        public override void Write(byte[] buf, int off, int len)
        {
            for (int i = off; i < off + len; i++)
                buf[i] = trans.transform(buf[i]);
            outs.Write(buf, off, len);
        }

        void IDisposable.Dispose()
        {
            outs.Dispose();
        }

        public override void Close()
        {
            outs.Close();
        }

        public override int Read(byte[] cbuf, int off, int count)
        {
            return outs.Read(cbuf, off, count);
        }
    }
}
