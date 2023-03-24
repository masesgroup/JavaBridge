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

namespace Java.Io
{
    #region ObjectInputStream
    public partial class ObjectInputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#%3Cinit%3E(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ObjectInputStream(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.ObjectInputStream"/> to <see cref="Java.Io.ObjectInput"/>
        /// </summary>
        public static implicit operator Java.Io.ObjectInput(Java.Io.ObjectInputStream t) => t.Cast<Java.Io.ObjectInput>();
        /// <summary>
        /// Converter from <see cref="Java.Io.ObjectInputStream"/> to <see cref="Java.Io.ObjectStreamConstants"/>
        /// </summary>
        public static implicit operator Java.Io.ObjectStreamConstants(Java.Io.ObjectInputStream t) => t.Cast<Java.Io.ObjectStreamConstants>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#getObjectInputFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#setObjectInputFilter(java.io.ObjectInputFilter)"/>
        /// </summary>
        public Java.Io.ObjectInputFilter ObjectInputFilter
        {
            get { return IExecute<Java.Io.ObjectInputFilter>("getObjectInputFilter"); } set { IExecute("setObjectInputFilter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readBoolean()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool ReadBoolean()
        {
            return IExecute<bool>("readBoolean");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readByte()"/>
        /// </summary>
        
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte ReadByte()
        {
            return IExecute<byte>("readByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readChar()"/>
        /// </summary>
        
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public char ReadChar()
        {
            return IExecute<char>("readChar");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readDouble()"/>
        /// </summary>
        
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public double ReadDouble()
        {
            return IExecute<double>("readDouble");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readObject()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public object ReadObject()
        {
            return IExecute("readObject");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readFloat()"/>
        /// </summary>
        
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public float ReadFloat()
        {
            return IExecute<float>("readFloat");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readInt()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadInt()
        {
            return IExecute<int>("readInt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readUnsignedByte()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedByte()
        {
            return IExecute<int>("readUnsignedByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readUnsignedShort()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedShort()
        {
            return IExecute<int>("readUnsignedShort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SkipBytes(int arg0)
        {
            return IExecute<int>("skipBytes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readFields()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Io.ObjectInputStream.GetField"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public Java.Io.ObjectInputStream.GetField ReadFields()
        {
            return IExecute<Java.Io.ObjectInputStream.GetField>("readFields");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readUnshared()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public object ReadUnshared()
        {
            return IExecute("readUnshared");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readUTF()"/>
        /// </summary>
        
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public string ReadUTF()
        {
            return IExecute<string>("readUTF");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readLong()"/>
        /// </summary>
        
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadLong()
        {
            return IExecute<long>("readLong");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readShort()"/>
        /// </summary>
        
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public short ReadShort()
        {
            return IExecute<short>("readShort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#defaultReadObject()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public void DefaultReadObject()
        {
            IExecute("defaultReadObject");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readFully(byte[],int,int)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0)
        {
            IExecute("readFully", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.html#registerValidation(java.io.ObjectInputValidation,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInputValidation"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.NotActiveException"/>
        /// <exception cref="Java.Io.InvalidObjectException"/>
        public void RegisterValidation(Java.Io.ObjectInputValidation arg0, int arg1)
        {
            IExecute("registerValidation", arg0, arg1);
        }
        
        #endregion

        #region Nested classes
        #region GetField
        public partial class GetField
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#getObjectStreamClass()"/> 
            /// </summary>
            public Java.Io.ObjectStreamClass ObjectStreamClass
            {
                get { return IExecute<Java.Io.ObjectStreamClass>("getObjectStreamClass"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#defaulted(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public bool Defaulted(string arg0)
            {
                return IExecute<bool>("defaulted", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public bool Get(string arg0, bool arg1)
            {
                return IExecute<bool>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,byte)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="byte"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public byte Get(string arg0, byte arg1)
            {
                return IExecute<byte>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,char)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="char"/></param>
            /// <returns><see cref="char"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public char Get(string arg0, char arg1)
            {
                return IExecute<char>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <returns><see cref="double"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public double Get(string arg0, double arg1)
            {
                return IExecute<double>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <returns><see cref="float"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public float Get(string arg0, float arg1)
            {
                return IExecute<float>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public int Get(string arg0, int arg1)
            {
                return IExecute<int>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public object Get(string arg0, object arg1)
            {
                return IExecute("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <returns><see cref="long"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public long Get(string arg0, long arg1)
            {
                return IExecute<long>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="short"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public short Get(string arg0, short arg1)
            {
                return IExecute<short>("get", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}