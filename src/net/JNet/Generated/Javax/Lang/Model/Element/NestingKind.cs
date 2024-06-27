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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Lang.Model.Element
{
    #region NestingKind
    public partial class NestingKind
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#ANONYMOUS"/>
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind ANONYMOUS { get { if (!_ANONYMOUSReady) { _ANONYMOUSContent = SGetField<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "ANONYMOUS"); _ANONYMOUSReady = true; } return _ANONYMOUSContent; } }
        private static Javax.Lang.Model.Element.NestingKind _ANONYMOUSContent = default;
        private static bool _ANONYMOUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#LOCAL"/>
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind LOCAL { get { if (!_LOCALReady) { _LOCALContent = SGetField<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "LOCAL"); _LOCALReady = true; } return _LOCALContent; } }
        private static Javax.Lang.Model.Element.NestingKind _LOCALContent = default;
        private static bool _LOCALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#MEMBER"/>
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind MEMBER { get { if (!_MEMBERReady) { _MEMBERContent = SGetField<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "MEMBER"); _MEMBERReady = true; } return _MEMBERContent; } }
        private static Javax.Lang.Model.Element.NestingKind _MEMBERContent = default;
        private static bool _MEMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#TOP_LEVEL"/>
        /// </summary>
        public static Javax.Lang.Model.Element.NestingKind TOP_LEVEL { get { if (!_TOP_LEVELReady) { _TOP_LEVELContent = SGetField<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "TOP_LEVEL"); _TOP_LEVELReady = true; } return _TOP_LEVELContent; } }
        private static Javax.Lang.Model.Element.NestingKind _TOP_LEVELContent = default;
        private static bool _TOP_LEVELReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Lang.Model.Element.NestingKind"/></returns>
        public static Javax.Lang.Model.Element.NestingKind ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/lang/model/element/NestingKind;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#values()"/>
        /// </summary>
        /// <returns><see cref="Javax.Lang.Model.Element.NestingKind"/></returns>
        public static Javax.Lang.Model.Element.NestingKind[] Values()
        {
            return SExecuteWithSignatureArray<Javax.Lang.Model.Element.NestingKind>(LocalBridgeClazz, "values", "()[Ljavax/lang/model/element/NestingKind;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/lang/model/element/NestingKind.html#isNested()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNested()
        {
            return IExecuteWithSignature<bool>("isNested", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}