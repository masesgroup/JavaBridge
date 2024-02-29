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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Spi
{
    #region IDirStateFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDirStateFactory : Javax.Naming.Spi.IStateFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.html#getStateToBind(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.Spi.DirStateFactory.Result"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Spi.DirStateFactory.Result GetStateToBind(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<object, object> arg3, Javax.Naming.Directory.Attributes arg4);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DirStateFactory
    public partial class DirStateFactory : Javax.Naming.Spi.IDirStateFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.html#getStateToBind(java.lang.Object,javax.naming.Name,javax.naming.Context,java.util.Hashtable,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Context"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        /// <param name="arg4"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.Spi.DirStateFactory.Result"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Spi.DirStateFactory.Result GetStateToBind(object arg0, Javax.Naming.Name arg1, Javax.Naming.Context arg2, Java.Util.Hashtable<object, object> arg3, Javax.Naming.Directory.Attributes arg4)
        {
            return IExecute<Javax.Naming.Spi.DirStateFactory.Result>("getStateToBind", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes
        #region Result
        public partial class Result
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.Result.html#%3Cinit%3E(java.lang.Object,javax.naming.directory.Attributes)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
            public Result(object arg0, Javax.Naming.Directory.Attributes arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.Result.html#getAttributes()"/> 
            /// </summary>
            public Javax.Naming.Directory.Attributes Attributes
            {
                get { return IExecuteWithSignature<Javax.Naming.Directory.Attributes>("getAttributes", "()Ljavax/naming/directory/Attributes;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/spi/DirStateFactory.Result.html#getObject()"/> 
            /// </summary>
            public object Object
            {
                get { return IExecuteWithSignature("getObject", "()Ljava/lang/Object;"); }
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