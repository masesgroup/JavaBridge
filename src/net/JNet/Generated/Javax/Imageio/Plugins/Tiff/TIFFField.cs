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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Plugins.Tiff
{
    #region TIFFField
    public partial class TIFFField
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#%3Cinit%3E(javax.imageio.plugins.tiff.TIFFTag,int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTag"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        public TIFFField(Javax.Imageio.Plugins.Tiff.TIFFTag arg0, int arg1, int arg2, object arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#%3Cinit%3E(javax.imageio.plugins.tiff.TIFFTag,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTag"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TIFFField(Javax.Imageio.Plugins.Tiff.TIFFTag arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#%3Cinit%3E(javax.imageio.plugins.tiff.TIFFTag,int,long,javax.imageio.plugins.tiff.TIFFDirectory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTag"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Javax.Imageio.Plugins.Tiff.TIFFDirectory"/></param>
        public TIFFField(Javax.Imageio.Plugins.Tiff.TIFFTag arg0, int arg1, long arg2, Javax.Imageio.Plugins.Tiff.TIFFDirectory arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#%3Cinit%3E(javax.imageio.plugins.tiff.TIFFTag,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTag"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public TIFFField(Javax.Imageio.Plugins.Tiff.TIFFTag arg0, long arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Imageio.Plugins.Tiff.TIFFField"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Imageio.Plugins.Tiff.TIFFField t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getTypeByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetTypeByName(string arg0)
        {
            return SExecute<int>(LocalClazz, "getTypeByName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#createArrayForType(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public static object CreateArrayForType(int arg0, int arg1)
        {
            return SExecute(LocalClazz, "createArrayForType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getTypeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string GetTypeName(int arg0)
        {
            return SExecute<string>(LocalClazz, "getTypeName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#createFromMetadataNode(javax.imageio.plugins.tiff.TIFFTagSet,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTagSet"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Javax.Imageio.Plugins.Tiff.TIFFField"/></returns>
        public static Javax.Imageio.Plugins.Tiff.TIFFField CreateFromMetadataNode(Javax.Imageio.Plugins.Tiff.TIFFTagSet arg0, Org.W3c.Dom.Node arg1)
        {
            return SExecute<Javax.Imageio.Plugins.Tiff.TIFFField>(LocalClazz, "createFromMetadataNode", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsBytes()"/> 
        /// </summary>
        public byte[] AsBytes
        {
            get { return IExecuteArray<byte>("getAsBytes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsChars()"/> 
        /// </summary>
        public char[] AsChars
        {
            get { return IExecuteArray<char>("getAsChars"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsDoubles()"/> 
        /// </summary>
        public double[] AsDoubles
        {
            get { return IExecuteArray<double>("getAsDoubles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsFloats()"/> 
        /// </summary>
        public float[] AsFloats
        {
            get { return IExecuteArray<float>("getAsFloats"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsInts()"/> 
        /// </summary>
        public int[] AsInts
        {
            get { return IExecuteArray<int>("getAsInts"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsLongs()"/> 
        /// </summary>
        public long[] AsLongs
        {
            get { return IExecuteArray<long>("getAsLongs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsNativeNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node AsNativeNode
        {
            get { return IExecute<Org.W3c.Dom.Node>("getAsNativeNode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsRationals()"/> 
        /// </summary>
        public long[] AsRationals
        {
            get { return IExecuteArray<long>("getAsRationals"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsShorts()"/> 
        /// </summary>
        public short[] AsShorts
        {
            get { return IExecuteArray<short>("getAsShorts"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsSRationals()"/> 
        /// </summary>
        public int[] AsSRationals
        {
            get { return IExecuteArray<int>("getAsSRationals"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getCount()"/> 
        /// </summary>
        public int Count
        {
            get { return IExecute<int>("getCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getData()"/> 
        /// </summary>
        public object Data
        {
            get { return IExecute("getData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getDirectory()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFDirectory Directory
        {
            get { return IExecute<Javax.Imageio.Plugins.Tiff.TIFFDirectory>("getDirectory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#hasDirectory()"/> 
        /// </summary>
        public bool HasDirectory
        {
            get { return IExecute<bool>("hasDirectory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#isIntegral()"/> 
        /// </summary>
        public bool IsIntegral
        {
            get { return IExecute<bool>("isIntegral"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getTag()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFTag Tag
        {
            get { return IExecute<Javax.Imageio.Plugins.Tiff.TIFFTag>("getTag"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getTagNumber()"/> 
        /// </summary>
        public int TagNumber
        {
            get { return IExecute<int>("getTagNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsDouble(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetAsDouble(int arg0)
        {
            return IExecute<double>("getAsDouble", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsFloat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetAsFloat(int arg0)
        {
            return IExecute<float>("getAsFloat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAsInt(int arg0)
        {
            return IExecute<int>("getAsInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsSRational(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetAsSRational(int arg0)
        {
            return IExecuteArray<int>("getAsSRational", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetAsString(int arg0)
        {
            return IExecute<string>("getAsString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getValueAsString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetValueAsString(int arg0)
        {
            return IExecute<string>("getValueAsString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#clone()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Imageio.Plugins.Tiff.TIFFField"/></returns>
        /// <exception cref="Java.Lang.CloneNotSupportedException"/>
        public Javax.Imageio.Plugins.Tiff.TIFFField Clone()
        {
            return IExecute<Javax.Imageio.Plugins.Tiff.TIFFField>("clone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAsLong(int arg0)
        {
            return IExecute<long>("getAsLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFField.html#getAsRational(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long[] GetAsRational(int arg0)
        {
            return IExecuteArray<long>("getAsRational", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}