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

namespace Javax.Imageio.Plugins.Tiff
{
    #region TIFFDirectory
    public partial class TIFFDirectory
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#%3Cinit%3E(javax.imageio.plugins.tiff.TIFFTagSet[],javax.imageio.plugins.tiff.TIFFTag)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTagSet"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTag"/></param>
        public TIFFDirectory(Javax.Imageio.Plugins.Tiff.TIFFTagSet[] arg0, Javax.Imageio.Plugins.Tiff.TIFFTag arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#createFromMetadata(javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <returns><see cref="Javax.Imageio.Plugins.Tiff.TIFFDirectory"/></returns>
        /// <exception cref="Javax.Imageio.Metadata.IIOInvalidTreeException"/>
        public static Javax.Imageio.Plugins.Tiff.TIFFDirectory CreateFromMetadata(Javax.Imageio.Metadata.IIOMetadata arg0)
        {
            return SExecuteWithSignature<Javax.Imageio.Plugins.Tiff.TIFFDirectory>(LocalBridgeClazz, "createFromMetadata", "(Ljavax/imageio/metadata/IIOMetadata;)Ljavax/imageio/plugins/tiff/TIFFDirectory;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getAsMetadata()"/> 
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadata AsMetadata
        {
            get { return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadata>("getAsMetadata", "()Ljavax/imageio/metadata/IIOMetadata;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getNumTIFFFields()"/> 
        /// </summary>
        public int NumTIFFFields
        {
            get { return IExecuteWithSignature<int>("getNumTIFFFields", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getParentTag()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFTag ParentTag
        {
            get { return IExecuteWithSignature<Javax.Imageio.Plugins.Tiff.TIFFTag>("getParentTag", "()Ljavax/imageio/plugins/tiff/TIFFTag;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getTagSets()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFTagSet[] TagSets
        {
            get { return IExecuteWithSignatureArray<Javax.Imageio.Plugins.Tiff.TIFFTagSet>("getTagSets", "()[Ljavax/imageio/plugins/tiff/TIFFTagSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getTIFFFields()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFField[] TIFFFields
        {
            get { return IExecuteWithSignatureArray<Javax.Imageio.Plugins.Tiff.TIFFField>("getTIFFFields", "()[Ljavax/imageio/plugins/tiff/TIFFField;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#containsTIFFField(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsTIFFField(int arg0)
        {
            return IExecuteWithSignature<bool>("containsTIFFField", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#clone()"/>
        /// </summary>

        /// <returns><see cref="Javax.Imageio.Plugins.Tiff.TIFFDirectory"/></returns>
        /// <exception cref="Java.Lang.CloneNotSupportedException"/>
        public Javax.Imageio.Plugins.Tiff.TIFFDirectory Clone()
        {
            return IExecuteWithSignature<Javax.Imageio.Plugins.Tiff.TIFFDirectory>("clone", "()Ljavax/imageio/plugins/tiff/TIFFDirectory;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getTIFFField(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Imageio.Plugins.Tiff.TIFFField"/></returns>
        public Javax.Imageio.Plugins.Tiff.TIFFField GetTIFFField(int arg0)
        {
            return IExecuteWithSignature<Javax.Imageio.Plugins.Tiff.TIFFField>("getTIFFField", "(I)Ljavax/imageio/plugins/tiff/TIFFField;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getTag(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Imageio.Plugins.Tiff.TIFFTag"/></returns>
        public Javax.Imageio.Plugins.Tiff.TIFFTag GetTag(int arg0)
        {
            return IExecuteWithSignature<Javax.Imageio.Plugins.Tiff.TIFFTag>("getTag", "(I)Ljavax/imageio/plugins/tiff/TIFFTag;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#addTagSet(javax.imageio.plugins.tiff.TIFFTagSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTagSet"/></param>
        public void AddTagSet(Javax.Imageio.Plugins.Tiff.TIFFTagSet arg0)
        {
            IExecuteWithSignature("addTagSet", "(Ljavax/imageio/plugins/tiff/TIFFTagSet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#addTIFFField(javax.imageio.plugins.tiff.TIFFField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Tiff.TIFFField"/></param>
        public void AddTIFFField(Javax.Imageio.Plugins.Tiff.TIFFField arg0)
        {
            IExecuteWithSignature("addTIFFField", "(Ljavax/imageio/plugins/tiff/TIFFField;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#removeTagSet(javax.imageio.plugins.tiff.TIFFTagSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTagSet"/></param>
        public void RemoveTagSet(Javax.Imageio.Plugins.Tiff.TIFFTagSet arg0)
        {
            IExecuteWithSignature("removeTagSet", "(Ljavax/imageio/plugins/tiff/TIFFTagSet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#removeTIFFField(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveTIFFField(int arg0)
        {
            IExecuteWithSignature("removeTIFFField", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#removeTIFFFields()"/>
        /// </summary>
        public void RemoveTIFFFields()
        {
            IExecuteWithSignature("removeTIFFFields", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}