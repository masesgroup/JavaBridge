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

namespace Java.Util.Prefs
{
    #region Preferences
    public partial class Preferences
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#MAX_KEY_LENGTH"/>
        /// </summary>
        public static int MAX_KEY_LENGTH => Clazz.GetField<int>("MAX_KEY_LENGTH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#MAX_NAME_LENGTH"/>
        /// </summary>
        public static int MAX_NAME_LENGTH => Clazz.GetField<int>("MAX_NAME_LENGTH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#MAX_VALUE_LENGTH"/>
        /// </summary>
        public static int MAX_VALUE_LENGTH => Clazz.GetField<int>("MAX_VALUE_LENGTH");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#systemRoot()"/> 
        /// </summary>
        public static Java.Util.Prefs.Preferences SystemRoot
        {
            get { return SExecute<Java.Util.Prefs.Preferences>(LocalClazz, "systemRoot"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#userRoot()"/> 
        /// </summary>
        public static Java.Util.Prefs.Preferences UserRoot
        {
            get { return SExecute<Java.Util.Prefs.Preferences>(LocalClazz, "userRoot"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#systemNodeForPackage(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public static Java.Util.Prefs.Preferences SystemNodeForPackage(Java.Lang.Class arg0)
        {
            return SExecute<Java.Util.Prefs.Preferences>(LocalClazz, "systemNodeForPackage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#userNodeForPackage(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public static Java.Util.Prefs.Preferences UserNodeForPackage(Java.Lang.Class arg0)
        {
            return SExecute<Java.Util.Prefs.Preferences>(LocalClazz, "userNodeForPackage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#importPreferences(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Util.Prefs.InvalidPreferencesFormatException"/>
        public static void ImportPreferences(Java.Io.InputStream arg0)
        {
            SExecute(LocalClazz, "importPreferences", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#absolutePath()"/> 
        /// </summary>
        public string AbsolutePath
        {
            get { return IExecute<string>("absolutePath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#childrenNames()"/> 
        /// </summary>
        public string[] ChildrenNames
        {
            get { return IExecuteArray<string>("childrenNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#isUserNode()"/> 
        /// </summary>
        public bool IsUserNode
        {
            get { return IExecute<bool>("isUserNode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#keys()"/> 
        /// </summary>
        public string[] Keys
        {
            get { return IExecuteArray<string>("keys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#name()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("name"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#parent()"/> 
        /// </summary>
        public Java.Util.Prefs.Preferences Parent
        {
            get { return IExecute<Java.Util.Prefs.Preferences>("parent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getBoolean(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetBoolean(string arg0, bool arg1)
        {
            return IExecute<bool>("getBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#nodeExists(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public bool NodeExists(string arg0)
        {
            return IExecute<bool>("nodeExists", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getByteArray(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetByteArray(string arg0, byte[] arg1)
        {
            return IExecuteArray<byte>("getByteArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getDouble(java.lang.String,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetDouble(string arg0, double arg1)
        {
            return IExecute<double>("getDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFloat(string arg0, float arg1)
        {
            return IExecute<float>("getFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInt(string arg0, int arg1)
        {
            return IExecute<int>("getInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#get(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string Get(string arg0, string arg1)
        {
            return IExecute<string>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#node(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public Java.Util.Prefs.Preferences Node(string arg0)
        {
            return IExecute<Java.Util.Prefs.Preferences>("node", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(string arg0, long arg1)
        {
            return IExecute<long>("getLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#addNodeChangeListener(java.util.prefs.NodeChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeListener"/></param>
        public void AddNodeChangeListener(Java.Util.Prefs.NodeChangeListener arg0)
        {
            IExecute("addNodeChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.PreferenceChangeListener"/></param>
        public void AddPreferenceChangeListener(Java.Util.Prefs.PreferenceChangeListener arg0)
        {
            IExecute("addPreferenceChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#clear()"/>
        /// </summary>
        
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#exportNode(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void ExportNode(Java.Io.OutputStream arg0)
        {
            IExecute("exportNode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#exportSubtree(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void ExportSubtree(Java.Io.OutputStream arg0)
        {
            IExecute("exportSubtree", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#flush()"/>
        /// </summary>
        
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void Flush()
        {
            IExecute("flush");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#put(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void Put(string arg0, string arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putBoolean(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void PutBoolean(string arg0, bool arg1)
        {
            IExecute("putBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putByteArray(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public void PutByteArray(string arg0, byte[] arg1)
        {
            IExecute("putByteArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putDouble(java.lang.String,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void PutDouble(string arg0, double arg1)
        {
            IExecute("putDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void PutFloat(string arg0, float arg1)
        {
            IExecute("putFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void PutInt(string arg0, int arg1)
        {
            IExecute("putInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void PutLong(string arg0, long arg1)
        {
            IExecute("putLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#remove(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void Remove(string arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#removeNode()"/>
        /// </summary>
        
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void RemoveNode()
        {
            IExecute("removeNode");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#removeNodeChangeListener(java.util.prefs.NodeChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeListener"/></param>
        public void RemoveNodeChangeListener(Java.Util.Prefs.NodeChangeListener arg0)
        {
            IExecute("removeNodeChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.PreferenceChangeListener"/></param>
        public void RemovePreferenceChangeListener(Java.Util.Prefs.PreferenceChangeListener arg0)
        {
            IExecute("removePreferenceChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#sync()"/>
        /// </summary>
        
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void Sync()
        {
            IExecute("sync");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}