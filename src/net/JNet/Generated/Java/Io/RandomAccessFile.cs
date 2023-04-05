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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region RandomAccessFile
    public partial class RandomAccessFile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#%3Cinit%3E(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public RandomAccessFile(Java.Io.File arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public RandomAccessFile(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.RandomAccessFile"/> to <see cref="Java.Io.DataOutput"/>
        /// </summary>
        public static implicit operator Java.Io.DataOutput(Java.Io.RandomAccessFile t) => t.Cast<Java.Io.DataOutput>();
        /// <summary>
        /// Converter from <see cref="Java.Io.RandomAccessFile"/> to <see cref="Java.Io.DataInput"/>
        /// </summary>
        public static implicit operator Java.Io.DataInput(Java.Io.RandomAccessFile t) => t.Cast<Java.Io.DataInput>();
        /// <summary>
        /// Converter from <see cref="Java.Io.RandomAccessFile"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Io.RandomAccessFile t) => t.Cast<Java.Io.Closeable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#getChannel()"/> 
        /// </summary>
        public Java.Nio.Channels.FileChannel Channel
        {
            get { return IExecute<Java.Nio.Channels.FileChannel>("getChannel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#getFD()"/> 
        /// </summary>
        public Java.Io.FileDescriptor FD
        {
            get { return IExecute<Java.Io.FileDescriptor>("getFD"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#getFilePointer()"/> 
        /// </summary>
        public long FilePointer
        {
            get { return IExecute<long>("getFilePointer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#length()"/> 
        /// </summary>
        public long Length
        {
            get { return IExecute<long>("length"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readBoolean()"/> 
        /// </summary>
        public bool ReadBoolean
        {
            get { return IExecute<bool>("readBoolean"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readByte()"/> 
        /// </summary>
        public byte ReadByte
        {
            get { return IExecute<byte>("readByte"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readChar()"/> 
        /// </summary>
        public char ReadChar
        {
            get { return IExecute<char>("readChar"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readDouble()"/> 
        /// </summary>
        public double ReadDouble
        {
            get { return IExecute<double>("readDouble"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readFloat()"/> 
        /// </summary>
        public float ReadFloat
        {
            get { return IExecute<float>("readFloat"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readInt()"/> 
        /// </summary>
        public int ReadInt
        {
            get { return IExecute<int>("readInt"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readLine()"/> 
        /// </summary>
        public string ReadLine
        {
            get { return IExecute<string>("readLine"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readLong()"/> 
        /// </summary>
        public long ReadLong
        {
            get { return IExecute<long>("readLong"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readShort()"/> 
        /// </summary>
        public short ReadShort
        {
            get { return IExecute<short>("readShort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readUnsignedByte()"/> 
        /// </summary>
        public int ReadUnsignedByte
        {
            get { return IExecute<int>("readUnsignedByte"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readUnsignedShort()"/> 
        /// </summary>
        public int ReadUnsignedShort
        {
            get { return IExecute<int>("readUnsignedShort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readUTF()"/> 
        /// </summary>
        public string ReadUTF
        {
            get { return IExecute<string>("readUTF"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readFully(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0)
        {
            IExecute("readFully", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeBoolean(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteBoolean(bool arg0)
        {
            IExecute("writeBoolean", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeByte(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteByte(int arg0)
        {
            IExecute("writeByte", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeBytes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteBytes(string arg0)
        {
            IExecute("writeBytes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeChar(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteChar(int arg0)
        {
            IExecute("writeChar", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeChars(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteChars(string arg0)
        {
            IExecute("writeChars", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteDouble(double arg0)
        {
            IExecute("writeDouble", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeFloat(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteFloat(float arg0)
        {
            IExecute("writeFloat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteInt(int arg0)
        {
            IExecute("writeInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteLong(long arg0)
        {
            IExecute("writeLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteShort(int arg0)
        {
            IExecute("writeShort", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#writeUTF(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteUTF(string arg0)
        {
            IExecute("writeUTF", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#read()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read()
        {
            return IExecute<int>("read");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#read(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#read(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(byte[] arg0)
        {
            return IExecute<int>("read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SkipBytes(int arg0)
        {
            return IExecute<int>("skipBytes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#setLength(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetLength(long arg0)
        {
            IExecute("setLength", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#close()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#seek(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Seek(long arg0)
        {
            IExecute("seek", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#write(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0, int arg1, int arg2)
        {
            IExecute("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#write(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0)
        {
            IExecute("write", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/RandomAccessFile.html#write(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(int arg0)
        {
            IExecute("write", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}