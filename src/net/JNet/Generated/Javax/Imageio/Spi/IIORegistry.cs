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

namespace Javax.Imageio.Spi
{
    #region IIORegistry
    public partial class IIORegistry
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/IIORegistry.html#getDefaultInstance()"/> 
        /// </summary>
        public static Javax.Imageio.Spi.IIORegistry DefaultInstance
        {
            get { return SExecuteWithSignature<Javax.Imageio.Spi.IIORegistry>(LocalBridgeClazz, "getDefaultInstance", "()Ljavax/imageio/spi/IIORegistry;"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/IIORegistry.html#registerApplicationClasspathSpis()"/>
        /// </summary>
        public void RegisterApplicationClasspathSpis()
        {
            IExecuteWithSignature("registerApplicationClasspathSpis", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}