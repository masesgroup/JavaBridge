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

namespace Javax.Tools
{
    #region DiagnosticCollector
    public partial class DiagnosticCollector
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticCollector.html#getDiagnostics()"/> 
        /// </summary>
        public Java.Util.List Diagnostics
        {
            get { return IExecuteWithSignature<Java.Util.List>("getDiagnostics", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticCollector.html#report(javax.tools.Diagnostic)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic"/></param>
        public void Report(Javax.Tools.Diagnostic arg0)
        {
            IExecuteWithSignature("report", "(Ljavax/tools/Diagnostic;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DiagnosticCollector<S>
    public partial class DiagnosticCollector<S>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.DiagnosticCollector{S}"/> to <see cref="Javax.Tools.DiagnosticCollector"/>
        /// </summary>
        public static implicit operator Javax.Tools.DiagnosticCollector(Javax.Tools.DiagnosticCollector<S> t) => t.Cast<Javax.Tools.DiagnosticCollector>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticCollector.html#getDiagnostics()"/> 
        /// </summary>
        public Java.Util.List Diagnostics
        {
            get { return IExecuteWithSignature<Java.Util.List>("getDiagnostics", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DiagnosticCollector.html#report(javax.tools.Diagnostic)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.Diagnostic"/></param>
        /// <typeparam name="Arg0ExtendsS"><typeparamref name="S"/></typeparam>
        public void Report<Arg0ExtendsS>(Javax.Tools.Diagnostic<Arg0ExtendsS> arg0) where Arg0ExtendsS : S
        {
            IExecuteWithSignature("report", "(Ljavax/tools/Diagnostic;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}