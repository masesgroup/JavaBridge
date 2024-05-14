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

namespace Javax.Imageio.Spi
{
    #region IIOServiceProvider
    public partial class IIOServiceProvider
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/IIOServiceProvider.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public IIOServiceProvider(Java.Lang.String arg0, Java.Lang.String arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/IIOServiceProvider.html#getVendorName()"/> 
        /// </summary>
        public Java.Lang.String VendorName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVendorName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/IIOServiceProvider.html#getVersion()"/> 
        /// </summary>
        public Java.Lang.String Version
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/IIOServiceProvider.html#getDescription(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDescription(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescription", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/IIOServiceProvider.html#onDeregistration(javax.imageio.spi.ServiceRegistry,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Spi.ServiceRegistry"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        public void OnDeregistration(Javax.Imageio.Spi.ServiceRegistry arg0, Java.Lang.Class arg1)
        {
            IExecute("onDeregistration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/IIOServiceProvider.html#onRegistration(javax.imageio.spi.ServiceRegistry,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Spi.ServiceRegistry"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        public void OnRegistration(Javax.Imageio.Spi.ServiceRegistry arg0, Java.Lang.Class arg1)
        {
            IExecute("onRegistration", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}