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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
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
        public static int MAX_KEY_LENGTH { get { if (!_MAX_KEY_LENGTHReady) { _MAX_KEY_LENGTHContent = SGetField<int>(LocalBridgeClazz, "MAX_KEY_LENGTH"); _MAX_KEY_LENGTHReady = true; } return _MAX_KEY_LENGTHContent; } }
        private static int _MAX_KEY_LENGTHContent = default;
        private static bool _MAX_KEY_LENGTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#MAX_NAME_LENGTH"/>
        /// </summary>
        public static int MAX_NAME_LENGTH { get { if (!_MAX_NAME_LENGTHReady) { _MAX_NAME_LENGTHContent = SGetField<int>(LocalBridgeClazz, "MAX_NAME_LENGTH"); _MAX_NAME_LENGTHReady = true; } return _MAX_NAME_LENGTHContent; } }
        private static int _MAX_NAME_LENGTHContent = default;
        private static bool _MAX_NAME_LENGTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#MAX_VALUE_LENGTH"/>
        /// </summary>
        public static int MAX_VALUE_LENGTH { get { if (!_MAX_VALUE_LENGTHReady) { _MAX_VALUE_LENGTHContent = SGetField<int>(LocalBridgeClazz, "MAX_VALUE_LENGTH"); _MAX_VALUE_LENGTHReady = true; } return _MAX_VALUE_LENGTHContent; } }
        private static int _MAX_VALUE_LENGTHContent = default;
        private static bool _MAX_VALUE_LENGTHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#systemNodeForPackage(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public static Java.Util.Prefs.Preferences SystemNodeForPackage(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<Java.Util.Prefs.Preferences>(LocalBridgeClazz, "systemNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#systemRoot()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public static Java.Util.Prefs.Preferences SystemRoot()
        {
            return SExecuteWithSignature<Java.Util.Prefs.Preferences>(LocalBridgeClazz, "systemRoot", "()Ljava/util/prefs/Preferences;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#userNodeForPackage(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public static Java.Util.Prefs.Preferences UserNodeForPackage(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<Java.Util.Prefs.Preferences>(LocalBridgeClazz, "userNodeForPackage", "(Ljava/lang/Class;)Ljava/util/prefs/Preferences;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#userRoot()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public static Java.Util.Prefs.Preferences UserRoot()
        {
            return SExecuteWithSignature<Java.Util.Prefs.Preferences>(LocalBridgeClazz, "userRoot", "()Ljava/util/prefs/Preferences;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#importPreferences(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Util.Prefs.InvalidPreferencesFormatException"/>
        public static void ImportPreferences(Java.Io.InputStream arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "importPreferences", "(Ljava/io/InputStream;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getBoolean(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetBoolean(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<bool>("getBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#isUserNode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUserNode()
        {
            return IExecuteWithSignature<bool>("isUserNode", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#nodeExists(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public bool NodeExists(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("nodeExists", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getByteArray(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetByteArray(Java.Lang.String arg0, byte[] arg1)
        {
            return IExecuteArray<byte>("getByteArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getDouble(java.lang.String,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetDouble(Java.Lang.String arg0, double arg1)
        {
            return IExecute<double>("getDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFloat(Java.Lang.String arg0, float arg1)
        {
            return IExecute<float>("getFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInt(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("getInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#absolutePath()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String AbsolutePath()
        {
            return IExecuteWithSignature<Java.Lang.String>("absolutePath", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#get(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Get(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#name()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#childrenNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public Java.Lang.String[] ChildrenNames()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("childrenNames", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#keys()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public Java.Lang.String[] Keys()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("keys", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#node(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public Java.Util.Prefs.Preferences Node(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Prefs.Preferences>("node", "(Ljava/lang/String;)Ljava/util/prefs/Preferences;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#parent()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Prefs.Preferences"/></returns>
        public Java.Util.Prefs.Preferences Parent()
        {
            return IExecuteWithSignature<Java.Util.Prefs.Preferences>("parent", "()Ljava/util/prefs/Preferences;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#getLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Lang.String arg0, long arg1)
        {
            return IExecute<long>("getLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#addNodeChangeListener(java.util.prefs.NodeChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeListener"/></param>
        public void AddNodeChangeListener(Java.Util.Prefs.NodeChangeListener arg0)
        {
            IExecuteWithSignature("addNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#addPreferenceChangeListener(java.util.prefs.PreferenceChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.PreferenceChangeListener"/></param>
        public void AddPreferenceChangeListener(Java.Util.Prefs.PreferenceChangeListener arg0)
        {
            IExecuteWithSignature("addPreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#clear()"/>
        /// </summary>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#exportNode(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void ExportNode(Java.Io.OutputStream arg0)
        {
            IExecuteWithSignature("exportNode", "(Ljava/io/OutputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#exportSubtree(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void ExportSubtree(Java.Io.OutputStream arg0)
        {
            IExecuteWithSignature("exportSubtree", "(Ljava/io/OutputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#put(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Put(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putBoolean(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void PutBoolean(Java.Lang.String arg0, bool arg1)
        {
            IExecute("putBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putByteArray(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public void PutByteArray(Java.Lang.String arg0, byte[] arg1)
        {
            IExecute("putByteArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putDouble(java.lang.String,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void PutDouble(Java.Lang.String arg0, double arg1)
        {
            IExecute("putDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void PutFloat(Java.Lang.String arg0, float arg1)
        {
            IExecute("putFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void PutInt(Java.Lang.String arg0, int arg1)
        {
            IExecute("putInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#putLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void PutLong(Java.Lang.String arg0, long arg1)
        {
            IExecute("putLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#remove(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Remove(Java.Lang.String arg0)
        {
            IExecuteWithSignature("remove", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#removeNode()"/>
        /// </summary>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void RemoveNode()
        {
            IExecuteWithSignature("removeNode", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#removeNodeChangeListener(java.util.prefs.NodeChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.NodeChangeListener"/></param>
        public void RemoveNodeChangeListener(Java.Util.Prefs.NodeChangeListener arg0)
        {
            IExecuteWithSignature("removeNodeChangeListener", "(Ljava/util/prefs/NodeChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#removePreferenceChangeListener(java.util.prefs.PreferenceChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.PreferenceChangeListener"/></param>
        public void RemovePreferenceChangeListener(Java.Util.Prefs.PreferenceChangeListener arg0)
        {
            IExecuteWithSignature("removePreferenceChangeListener", "(Ljava/util/prefs/PreferenceChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/Preferences.html#sync()"/>
        /// </summary>
        /// <exception cref="Java.Util.Prefs.BackingStoreException"/>
        public void Sync()
        {
            IExecuteWithSignature("sync", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}