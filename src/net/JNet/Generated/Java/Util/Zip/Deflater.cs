/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Zip
{
    #region Deflater
    public partial class Deflater
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#<init>(int,boolean)
        /// </summary>
        public Deflater(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#<init>(int)
        /// </summary>
        public Deflater(int arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#BEST_COMPRESSION
        /// </summary>
        public static int BEST_COMPRESSION => Clazz.GetField<int>("BEST_COMPRESSION");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#BEST_SPEED
        /// </summary>
        public static int BEST_SPEED => Clazz.GetField<int>("BEST_SPEED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#DEFAULT_COMPRESSION
        /// </summary>
        public static int DEFAULT_COMPRESSION => Clazz.GetField<int>("DEFAULT_COMPRESSION");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#DEFAULT_STRATEGY
        /// </summary>
        public static int DEFAULT_STRATEGY => Clazz.GetField<int>("DEFAULT_STRATEGY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#DEFLATED
        /// </summary>
        public static int DEFLATED => Clazz.GetField<int>("DEFLATED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#FILTERED
        /// </summary>
        public static int FILTERED => Clazz.GetField<int>("FILTERED");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#FULL_FLUSH
        /// </summary>
        public static int FULL_FLUSH => Clazz.GetField<int>("FULL_FLUSH");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#HUFFMAN_ONLY
        /// </summary>
        public static int HUFFMAN_ONLY => Clazz.GetField<int>("HUFFMAN_ONLY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#NO_COMPRESSION
        /// </summary>
        public static int NO_COMPRESSION => Clazz.GetField<int>("NO_COMPRESSION");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#NO_FLUSH
        /// </summary>
        public static int NO_FLUSH => Clazz.GetField<int>("NO_FLUSH");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#SYNC_FLUSH
        /// </summary>
        public static int SYNC_FLUSH => Clazz.GetField<int>("SYNC_FLUSH");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getAdler() 
        /// </summary>
        public int Adler
        {
            get { return IExecute<int>("getAdler"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getBytesRead() 
        /// </summary>
        public long BytesRead
        {
            get { return IExecute<long>("getBytesRead"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getBytesWritten() 
        /// </summary>
        public long BytesWritten
        {
            get { return IExecute<long>("getBytesWritten"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getTotalIn() 
        /// </summary>
        public int TotalIn
        {
            get { return IExecute<int>("getTotalIn"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getTotalOut() 
        /// </summary>
        public int TotalOut
        {
            get { return IExecute<int>("getTotalOut"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#finished()
        /// </summary>
        public bool Finished()
        {
            return IExecute<bool>("finished");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#needsInput()
        /// </summary>
        public bool NeedsInput()
        {
            return IExecute<bool>("needsInput");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(byte[],int,int,int)
        /// </summary>
        public int Deflate(byte[] arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<int>("deflate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(byte[],int,int)
        /// </summary>
        public int Deflate(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("deflate", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(byte[])
        /// </summary>
        public int Deflate(byte[] arg0)
        {
            return IExecute<int>("deflate", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(java.nio.ByteBuffer,int)
        /// </summary>
        public int Deflate(Java.Nio.ByteBuffer arg0, int arg1)
        {
            return IExecute<int>("deflate", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(java.nio.ByteBuffer)
        /// </summary>
        public int Deflate(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<int>("deflate", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#end()
        /// </summary>
        public void End()
        {
            IExecute("end");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#finish()
        /// </summary>
        public void Finish()
        {
            IExecute("finish");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#reset()
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setDictionary(byte[],int,int)
        /// </summary>
        public void SetDictionary(byte[] arg0, int arg1, int arg2)
        {
            IExecute("setDictionary", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setDictionary(byte[])
        /// </summary>
        public void SetDictionary(byte[] arg0)
        {
            IExecute("setDictionary", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setInput(byte[],int,int)
        /// </summary>
        public void SetInput(byte[] arg0, int arg1, int arg2)
        {
            IExecute("setInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setInput(byte[])
        /// </summary>
        public void SetInput(byte[] arg0)
        {
            IExecute("setInput", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setLevel(int)
        /// </summary>
        public void SetLevel(int arg0)
        {
            IExecute("setLevel", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setStrategy(int)
        /// </summary>
        public void SetStrategy(int arg0)
        {
            IExecute("setStrategy", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}