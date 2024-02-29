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

namespace Javax.Imageio
{
    #region IIOParam
    public partial class IIOParam
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getController()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setController(javax.imageio.IIOParamController)"/>
        /// </summary>
        public Javax.Imageio.IIOParamController Controller
        {
            get { return IExecuteWithSignature<Javax.Imageio.IIOParamController>("getController", "()Ljavax/imageio/IIOParamController;"); } set { IExecuteWithSignature("setController", "(Ljavax/imageio/IIOParamController;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getDefaultController()"/> 
        /// </summary>
        public Javax.Imageio.IIOParamController DefaultController
        {
            get { return IExecuteWithSignature<Javax.Imageio.IIOParamController>("getDefaultController", "()Ljavax/imageio/IIOParamController;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getDestinationOffset()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setDestinationOffset(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point DestinationOffset
        {
            get { return IExecuteWithSignature<Java.Awt.Point>("getDestinationOffset", "()Ljava/awt/Point;"); } set { IExecuteWithSignature("setDestinationOffset", "(Ljava/awt/Point;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getDestinationType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setDestinationType(javax.imageio.ImageTypeSpecifier)"/>
        /// </summary>
        public Javax.Imageio.ImageTypeSpecifier DestinationType
        {
            get { return IExecuteWithSignature<Javax.Imageio.ImageTypeSpecifier>("getDestinationType", "()Ljavax/imageio/ImageTypeSpecifier;"); } set { IExecuteWithSignature("setDestinationType", "(Ljavax/imageio/ImageTypeSpecifier;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSourceBands()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setSourceBands(int[])"/>
        /// </summary>
        public int[] SourceBands
        {
            get { return IExecuteWithSignatureArray<int>("getSourceBands", "()[I"); } set { IExecuteWithSignature("setSourceBands", "([I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSourceRegion()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setSourceRegion(java.awt.Rectangle)"/>
        /// </summary>
        public Java.Awt.Rectangle SourceRegion
        {
            get { return IExecuteWithSignature<Java.Awt.Rectangle>("getSourceRegion", "()Ljava/awt/Rectangle;"); } set { IExecuteWithSignature("setSourceRegion", "(Ljava/awt/Rectangle;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSourceXSubsampling()"/> 
        /// </summary>
        public int SourceXSubsampling
        {
            get { return IExecuteWithSignature<int>("getSourceXSubsampling", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSourceYSubsampling()"/> 
        /// </summary>
        public int SourceYSubsampling
        {
            get { return IExecuteWithSignature<int>("getSourceYSubsampling", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSubsamplingXOffset()"/> 
        /// </summary>
        public int SubsamplingXOffset
        {
            get { return IExecuteWithSignature<int>("getSubsamplingXOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#getSubsamplingYOffset()"/> 
        /// </summary>
        public int SubsamplingYOffset
        {
            get { return IExecuteWithSignature<int>("getSubsamplingYOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#activateController()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool ActivateController()
        {
            return IExecuteWithSignature<bool>("activateController", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#hasController()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasController()
        {
            return IExecuteWithSignature<bool>("hasController", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOParam.html#setSourceSubsampling(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetSourceSubsampling(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setSourceSubsampling", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}