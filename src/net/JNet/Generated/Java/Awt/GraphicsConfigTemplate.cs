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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region GraphicsConfigTemplate
    public partial class GraphicsConfigTemplate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#PREFERRED"/>
        /// </summary>
        public static int PREFERRED { get { if (!_PREFERREDReady) { _PREFERREDContent = SGetField<int>(LocalBridgeClazz, "PREFERRED"); _PREFERREDReady = true; } return _PREFERREDContent; } }
        private static int _PREFERREDContent = default;
        private static bool _PREFERREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#REQUIRED"/>
        /// </summary>
        public static int REQUIRED { get { if (!_REQUIREDReady) { _REQUIREDContent = SGetField<int>(LocalBridgeClazz, "REQUIRED"); _REQUIREDReady = true; } return _REQUIREDContent; } }
        private static int _REQUIREDContent = default;
        private static bool _REQUIREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#UNNECESSARY"/>
        /// </summary>
        public static int UNNECESSARY { get { if (!_UNNECESSARYReady) { _UNNECESSARYContent = SGetField<int>(LocalBridgeClazz, "UNNECESSARY"); _UNNECESSARYReady = true; } return _UNNECESSARYContent; } }
        private static int _UNNECESSARYContent = default;
        private static bool _UNNECESSARYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#isGraphicsConfigSupported(java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsGraphicsConfigSupported(Java.Awt.GraphicsConfiguration arg0)
        {
            return IExecuteWithSignature<bool>("isGraphicsConfigSupported", "(Ljava/awt/GraphicsConfiguration;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfigTemplate.html#getBestConfiguration(java.awt.GraphicsConfiguration[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        /// <returns><see cref="Java.Awt.GraphicsConfiguration"/></returns>
        public Java.Awt.GraphicsConfiguration GetBestConfiguration(Java.Awt.GraphicsConfiguration[] arg0)
        {
            return IExecuteWithSignature<Java.Awt.GraphicsConfiguration>("getBestConfiguration", "([Ljava/awt/GraphicsConfiguration;)Ljava/awt/GraphicsConfiguration;", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}