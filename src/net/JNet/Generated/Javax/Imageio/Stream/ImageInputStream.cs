/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Stream
{
    #region IImageInputStream
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IImageInputStream
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getBitOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#setBitOffset(int)"/>
        /// </summary>
        int BitOffset { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getByteOrder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#setByteOrder(java.nio.ByteOrder)"/>
        /// </summary>
        Java.Nio.ByteOrder ByteOrder { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getFlushedPosition()"/> 
        /// </summary>
        long FlushedPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getStreamPosition()"/> 
        /// </summary>
        long StreamPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCached()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCached();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCachedFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCachedFile();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCachedMemory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCachedMemory();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        bool ReadBoolean();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        byte ReadByte();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readChar()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        char ReadChar();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        double ReadDouble();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        float ReadFloat();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int Read();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int Read(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int Read(byte[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadBit();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadInt();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedByte()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadUnsignedByte();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedShort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadUnsignedShort();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int SkipBytes(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.String ReadLine();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUTF()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.String ReadUTF();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#length()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long Length();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long ReadBits(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long ReadLong();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedInt()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long ReadUnsignedInt();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#skipBytes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long SkipBytes(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        short ReadShort();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Flush();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#flushBefore(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void FlushBefore(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#mark()"/>
        /// </summary>
        void Mark();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBytes(javax.imageio.stream.IIOByteBuffer,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Stream.IIOByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadBytes(Javax.Imageio.Stream.IIOByteBuffer arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(byte[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(char[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(double[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(float[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(int[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(long[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(long[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(short[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(short[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#reset()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Reset();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#seek(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void Seek(long arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ImageInputStream
    public partial class ImageInputStream : Javax.Imageio.Stream.IImageInputStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Stream.ImageInputStream"/> to <see cref="Java.Io.DataInput"/>
        /// </summary>
        public static implicit operator Java.Io.DataInput(Javax.Imageio.Stream.ImageInputStream t) => t.Cast<Java.Io.DataInput>();
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Stream.ImageInputStream"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Javax.Imageio.Stream.ImageInputStream t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getBitOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#setBitOffset(int)"/>
        /// </summary>
        public int BitOffset
        {
            get { return IExecuteWithSignature<int>("getBitOffset", "()I"); } set { IExecuteWithSignature("setBitOffset", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getByteOrder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#setByteOrder(java.nio.ByteOrder)"/>
        /// </summary>
        public Java.Nio.ByteOrder ByteOrder
        {
            get { return IExecuteWithSignature<Java.Nio.ByteOrder>("getByteOrder", "()Ljava/nio/ByteOrder;"); } set { IExecuteWithSignature("setByteOrder", "(Ljava/nio/ByteOrder;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getFlushedPosition()"/> 
        /// </summary>
        public long FlushedPosition
        {
            get { return IExecuteWithSignature<long>("getFlushedPosition", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#getStreamPosition()"/> 
        /// </summary>
        public long StreamPosition
        {
            get { return IExecuteWithSignature<long>("getStreamPosition", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCached()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCached()
        {
            return IExecuteWithSignature<bool>("isCached", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCachedFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCachedFile()
        {
            return IExecuteWithSignature<bool>("isCachedFile", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#isCachedMemory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCachedMemory()
        {
            return IExecuteWithSignature<bool>("isCachedMemory", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool ReadBoolean()
        {
            return IExecuteWithSignature<bool>("readBoolean", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte ReadByte()
        {
            return IExecuteWithSignature<byte>("readByte", "()B");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readChar()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public char ReadChar()
        {
            return IExecuteWithSignature<char>("readChar", "()C");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public double ReadDouble()
        {
            return IExecuteWithSignature<double>("readDouble", "()D");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public float ReadFloat()
        {
            return IExecuteWithSignature<float>("readFloat", "()F");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read()
        {
            return IExecuteWithSignature<int>("read", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read(byte[],int,int)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#read(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(byte[] arg0)
        {
            return IExecuteWithSignature<int>("read", "([B)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadBit()
        {
            return IExecuteWithSignature<int>("readBit", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadInt()
        {
            return IExecuteWithSignature<int>("readInt", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedByte()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedByte()
        {
            return IExecuteWithSignature<int>("readUnsignedByte", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedShort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedShort()
        {
            return IExecuteWithSignature<int>("readUnsignedShort", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SkipBytes(int arg0)
        {
            return IExecuteWithSignature<int>("skipBytes", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String ReadLine()
        {
            return IExecuteWithSignature<Java.Lang.String>("readLine", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUTF()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String ReadUTF()
        {
            return IExecuteWithSignature<Java.Lang.String>("readUTF", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#length()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Length()
        {
            return IExecuteWithSignature<long>("length", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadBits(int arg0)
        {
            return IExecuteWithSignature<long>("readBits", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadLong()
        {
            return IExecuteWithSignature<long>("readLong", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readUnsignedInt()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadUnsignedInt()
        {
            return IExecuteWithSignature<long>("readUnsignedInt", "()J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#skipBytes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long SkipBytes(long arg0)
        {
            return IExecuteWithSignature<long>("skipBytes", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public short ReadShort()
        {
            return IExecuteWithSignature<short>("readShort", "()S");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#flushBefore(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void FlushBefore(long arg0)
        {
            IExecuteWithSignature("flushBefore", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#mark()"/>
        /// </summary>
        public void Mark()
        {
            IExecuteWithSignature("mark", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readBytes(javax.imageio.stream.IIOByteBuffer,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Stream.IIOByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadBytes(Javax.Imageio.Stream.IIOByteBuffer arg0, int arg1)
        {
            IExecute("readBytes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(byte[],int,int)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0)
        {
            IExecuteWithSignature("readFully", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(char[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(double[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(float[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(float[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(int[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(long[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(long[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#readFully(short[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(short[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#reset()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/stream/ImageInputStream.html#seek(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Seek(long arg0)
        {
            IExecuteWithSignature("seek", "(J)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}