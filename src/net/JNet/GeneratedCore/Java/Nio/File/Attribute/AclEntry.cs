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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Attribute
{
    #region AclEntry definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html"/>
    /// </summary>
    public partial class AclEntry : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AclEntry>
    {
        const string _bridgeClassName = "java.nio.file.attribute.AclEntry";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AclEntry() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AclEntry(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region Builder definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "java.nio.file.attribute.AclEntry$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region AclEntry
    public partial class AclEntry
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#newBuilder()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
        public static Java.Nio.File.Attribute.AclEntry.Builder NewBuilder()
        {
            return SExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>(LocalBridgeClazz, "newBuilder", "()Ljava/nio/file/attribute/AclEntry$Builder;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#newBuilder(java.nio.file.attribute.AclEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.AclEntry"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
        public static Java.Nio.File.Attribute.AclEntry.Builder NewBuilder(Java.Nio.File.Attribute.AclEntry arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>(LocalBridgeClazz, "newBuilder", "(Ljava/nio/file/attribute/AclEntry;)Ljava/nio/file/attribute/AclEntry$Builder;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#type()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryType"/></returns>
        public Java.Nio.File.Attribute.AclEntryType Type()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntryType>("type", "()Ljava/nio/file/attribute/AclEntryType;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#principal()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.UserPrincipal"/></returns>
        public Java.Nio.File.Attribute.UserPrincipal Principal()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.UserPrincipal>("principal", "()Ljava/nio/file/attribute/UserPrincipal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#flags()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Nio.File.Attribute.AclEntryFlag> Flags()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Nio.File.Attribute.AclEntryFlag>>("flags", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#permissions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Nio.File.Attribute.AclEntryPermission> Permissions()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Nio.File.Attribute.AclEntryPermission>>("permissions", "()Ljava/util/Set;");
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry"/></returns>
            public Java.Nio.File.Attribute.AclEntry Build()
            {
                return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntry>("build", "()Ljava/nio/file/attribute/AclEntry;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setFlags(java.nio.file.attribute.AclEntryFlag[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.File.Attribute.AclEntryFlag"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetFlags(params Java.Nio.File.Attribute.AclEntryFlag[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>("setFlags", "([Ljava/nio/file/attribute/AclEntryFlag;)Ljava/nio/file/attribute/AclEntry$Builder;"); else return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>("setFlags", "([Ljava/nio/file/attribute/AclEntryFlag;)Ljava/nio/file/attribute/AclEntry$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setFlags(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetFlags(Java.Util.Set<Java.Nio.File.Attribute.AclEntryFlag> arg0)
            {
                return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>("setFlags", "(Ljava/util/Set;)Ljava/nio/file/attribute/AclEntry$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setPermissions(java.nio.file.attribute.AclEntryPermission[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.File.Attribute.AclEntryPermission"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetPermissions(params Java.Nio.File.Attribute.AclEntryPermission[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>("setPermissions", "([Ljava/nio/file/attribute/AclEntryPermission;)Ljava/nio/file/attribute/AclEntry$Builder;"); else return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>("setPermissions", "([Ljava/nio/file/attribute/AclEntryPermission;)Ljava/nio/file/attribute/AclEntry$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setPermissions(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetPermissions(Java.Util.Set<Java.Nio.File.Attribute.AclEntryPermission> arg0)
            {
                return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>("setPermissions", "(Ljava/util/Set;)Ljava/nio/file/attribute/AclEntry$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setPrincipal(java.nio.file.attribute.UserPrincipal)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.File.Attribute.UserPrincipal"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetPrincipal(Java.Nio.File.Attribute.UserPrincipal arg0)
            {
                return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>("setPrincipal", "(Ljava/nio/file/attribute/UserPrincipal;)Ljava/nio/file/attribute/AclEntry$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setType(java.nio.file.attribute.AclEntryType)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.File.Attribute.AclEntryType"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetType(Java.Nio.File.Attribute.AclEntryType arg0)
            {
                return IExecuteWithSignature<Java.Nio.File.Attribute.AclEntry.Builder>("setType", "(Ljava/nio/file/attribute/AclEntryType;)Ljava/nio/file/attribute/AclEntry$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}