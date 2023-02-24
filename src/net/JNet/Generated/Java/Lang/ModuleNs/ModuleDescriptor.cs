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

namespace Java.Lang.ModuleNs
{
    #region ModuleDescriptor
    public partial class ModuleDescriptor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#read(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Lang.ModuleNs.ModuleDescriptor Read(Java.Io.InputStream arg0)
        {
            return SExecute<Java.Lang.ModuleNs.ModuleDescriptor>("read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#read(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor"/></returns>
        public static Java.Lang.ModuleNs.ModuleDescriptor Read(Java.Nio.ByteBuffer arg0)
        {
            return SExecute<Java.Lang.ModuleNs.ModuleDescriptor>("read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#newAutomaticModule(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
        public static Java.Lang.ModuleNs.ModuleDescriptor.Builder NewAutomaticModule(string arg0)
        {
            return SExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("newAutomaticModule", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#newModule(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
        public static Java.Lang.ModuleNs.ModuleDescriptor.Builder NewModule(string arg0)
        {
            return SExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("newModule", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#newOpenModule(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
        public static Java.Lang.ModuleNs.ModuleDescriptor.Builder NewOpenModule(string arg0)
        {
            return SExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("newOpenModule", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#isAutomatic()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsAutomatic()
        {
            return IExecute<bool>("isAutomatic");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#isOpen()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsOpen()
        {
            return IExecute<bool>("isOpen");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#compareTo(java.lang.module.ModuleDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor"/></param>
        /// <returns><see langword="int"/></returns>
        public int CompareTo(Java.Lang.ModuleNs.ModuleDescriptor arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#name()"/>
        /// </summary>
        
        /// <returns><see langword="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.html#toNameAndVersion()"/>
        /// </summary>
        
        /// <returns><see langword="string"/></returns>
        public string ToNameAndVersion()
        {
            return IExecute<string>("toNameAndVersion");
        }
        
        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#build()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor Build()
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor>("build");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#exports(java.lang.module.ModuleDescriptor$Exports)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Exports"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder ExportsMethod(Java.Lang.ModuleNs.ModuleDescriptor.Exports arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("exports", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#exports(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder ExportsMethod(string arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("exports", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#mainClass(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder MainClass(string arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("mainClass", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#opens(java.lang.module.ModuleDescriptor$Opens)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Opens"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder OpensMethod(Java.Lang.ModuleNs.ModuleDescriptor.Opens arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("opens", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#opens(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder OpensMethod(string arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("opens", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#provides(java.lang.module.ModuleDescriptor$Provides)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Provides"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder ProvidesMethod(Java.Lang.ModuleNs.ModuleDescriptor.Provides arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("provides", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#requires(java.lang.module.ModuleDescriptor$Requires)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Requires"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder RequiresMethod(Java.Lang.ModuleNs.ModuleDescriptor.Requires arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("requires", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#requires(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder RequiresMethod(string arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("requires", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#uses(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder Uses(string arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("uses", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#version(java.lang.module.ModuleDescriptor$Version)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Version"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder VersionMethod(Java.Lang.ModuleNs.ModuleDescriptor.Version arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("version", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Builder.html#version(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Builder"/></returns>
            public Java.Lang.ModuleNs.ModuleDescriptor.Builder VersionMethod(string arg0)
            {
                return IExecute<Java.Lang.ModuleNs.ModuleDescriptor.Builder>("version", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Exports
        public partial class Exports
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Exports.html#isQualified()"/>
            /// </summary>
            
            /// <returns><see langword="bool"/></returns>
            public bool IsQualified()
            {
                return IExecute<bool>("isQualified");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Exports.html#compareTo(java.lang.module.ModuleDescriptor$Exports)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Exports"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(Java.Lang.ModuleNs.ModuleDescriptor.Exports arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Exports.html#compareTo(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see langword="object"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(object arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Exports.html#source()"/>
            /// </summary>
            
            /// <returns><see langword="string"/></returns>
            public string Source()
            {
                return IExecute<string>("source");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Modifier
        public partial class Modifier
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Modifier.html#AUTOMATIC"/>
            /// </summary>
            public static Java.Lang.ModuleNs.ModuleDescriptor.Modifier AUTOMATIC => Clazz.GetField<Java.Lang.ModuleNs.ModuleDescriptor.Modifier>("AUTOMATIC");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Modifier.html#MANDATED"/>
            /// </summary>
            public static Java.Lang.ModuleNs.ModuleDescriptor.Modifier MANDATED => Clazz.GetField<Java.Lang.ModuleNs.ModuleDescriptor.Modifier>("MANDATED");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Modifier.html#OPEN"/>
            /// </summary>
            public static Java.Lang.ModuleNs.ModuleDescriptor.Modifier OPEN => Clazz.GetField<Java.Lang.ModuleNs.ModuleDescriptor.Modifier>("OPEN");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Modifier.html#SYNTHETIC"/>
            /// </summary>
            public static Java.Lang.ModuleNs.ModuleDescriptor.Modifier SYNTHETIC => Clazz.GetField<Java.Lang.ModuleNs.ModuleDescriptor.Modifier>("SYNTHETIC");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Modifier.html#values()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Modifier"/></returns>
            public static Java.Lang.ModuleNs.ModuleDescriptor.Modifier[] Values()
            {
                return SExecuteArray<Java.Lang.ModuleNs.ModuleDescriptor.Modifier>("values");
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Opens
        public partial class Opens
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Opens.html#isQualified()"/>
            /// </summary>
            
            /// <returns><see langword="bool"/></returns>
            public bool IsQualified()
            {
                return IExecute<bool>("isQualified");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Opens.html#compareTo(java.lang.module.ModuleDescriptor$Opens)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Opens"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(Java.Lang.ModuleNs.ModuleDescriptor.Opens arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Opens.html#compareTo(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see langword="object"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(object arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Opens.html#source()"/>
            /// </summary>
            
            /// <returns><see langword="string"/></returns>
            public string Source()
            {
                return IExecute<string>("source");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Provides
        public partial class Provides
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Provides.html#compareTo(java.lang.module.ModuleDescriptor$Provides)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Provides"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(Java.Lang.ModuleNs.ModuleDescriptor.Provides arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Provides.html#compareTo(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see langword="object"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(object arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Provides.html#service()"/>
            /// </summary>
            
            /// <returns><see langword="string"/></returns>
            public string Service()
            {
                return IExecute<string>("service");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Requires
        public partial class Requires
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Requires.html#compareTo(java.lang.module.ModuleDescriptor$Requires)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Requires"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(Java.Lang.ModuleNs.ModuleDescriptor.Requires arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Requires.html#compareTo(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see langword="object"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(object arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Requires.html#name()"/>
            /// </summary>
            
            /// <returns><see langword="string"/></returns>
            public string Name()
            {
                return IExecute<string>("name");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Version
        public partial class Version
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Version.html#parse(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see langword="string"/></param>
            /// <returns><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Version"/></returns>
            public static Java.Lang.ModuleNs.ModuleDescriptor.Version Parse(string arg0)
            {
                return SExecute<Java.Lang.ModuleNs.ModuleDescriptor.Version>("parse", arg0);
            }
            
            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Version.html#compareTo(java.lang.module.ModuleDescriptor$Version)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleDescriptor.Version"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(Java.Lang.ModuleNs.ModuleDescriptor.Version arg0)
            {
                return IExecute<int>("compareTo", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleDescriptor.Version.html#compareTo(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see langword="object"/></param>
            /// <returns><see langword="int"/></returns>
            public int CompareTo(object arg0)
            {
                return IExecute<int>("compareTo", arg0);
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