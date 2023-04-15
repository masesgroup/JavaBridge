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

namespace Java.Lang.ModuleNs
{
    #region ModuleFinder
    public partial class ModuleFinder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleFinder.html#ofSystem()"/> 
        /// </summary>
        public static Java.Lang.ModuleNs.ModuleFinder OfSystem
        {
            get { return SExecute<Java.Lang.ModuleNs.ModuleFinder>(LocalClazz, "ofSystem"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleFinder.html#compose(java.lang.module.ModuleFinder[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ModuleNs.ModuleFinder"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.ModuleFinder"/></returns>
        public static Java.Lang.ModuleNs.ModuleFinder Compose(params Java.Lang.ModuleNs.ModuleFinder[] arg0)
        {
            if (arg0.Length == 0) return SExecute<Java.Lang.ModuleNs.ModuleFinder>(LocalClazz, "compose", new object[] { arg0 }); else return SExecute<Java.Lang.ModuleNs.ModuleFinder>(LocalClazz, "compose", new object[] { arg0 }, arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleFinder.html#of(java.nio.file.Path[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Lang.ModuleNs.ModuleFinder"/></returns>
        public static Java.Lang.ModuleNs.ModuleFinder Of(params Java.Nio.File.Path[] arg0)
        {
            if (arg0.Length == 0) return SExecute<Java.Lang.ModuleNs.ModuleFinder>(LocalClazz, "of", new object[] { arg0 }); else return SExecute<Java.Lang.ModuleNs.ModuleFinder>(LocalClazz, "of", new object[] { arg0 }, arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleFinder.html#findAll()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.ModuleNs.ModuleReference> FindAll
        {
            get { return IExecute<Java.Util.Set<Java.Lang.ModuleNs.ModuleReference>>("findAll"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/module/ModuleFinder.html#find(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.ModuleNs.ModuleReference> Find(string arg0)
        {
            return IExecute<Java.Util.Optional<Java.Lang.ModuleNs.ModuleReference>>("find", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}