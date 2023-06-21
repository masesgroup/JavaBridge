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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region DiagnosticListener
    public partial class DiagnosticListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticListener.html#report(javax.tools.Diagnostic)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic"/></param>
        public virtual void Report(Javax.Tools.Diagnostic arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IDiagnosticListener<S>
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticListener.html"/>
    /// </summary>
    public partial interface IDiagnosticListener<S>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticListener.html#report(javax.tools.Diagnostic)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic"/></param>
        /// <typeparam name="Arg0ExtendsS"><typeparamref name="S"/></typeparam>
        void Report<Arg0ExtendsS>(Javax.Tools.Diagnostic<Arg0ExtendsS> arg0) where Arg0ExtendsS: S;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DiagnosticListener<S>
    public partial class DiagnosticListener<S> : Javax.Tools.IDiagnosticListener<S>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticListener.html#report(javax.tools.Diagnostic)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic"/></param>
        /// <typeparam name="Arg0ExtendsS"><typeparamref name="S"/></typeparam>
        public virtual void Report<Arg0ExtendsS>(Javax.Tools.Diagnostic<Arg0ExtendsS> arg0) where Arg0ExtendsS: S
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}