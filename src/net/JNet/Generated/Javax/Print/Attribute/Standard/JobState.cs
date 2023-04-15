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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region JobState
    public partial class JobState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.JobState"/> to <see cref="Javax.Print.Attribute.PrintJobAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintJobAttribute(Javax.Print.Attribute.Standard.JobState t) => t.Cast<Javax.Print.Attribute.PrintJobAttribute>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#ABORTED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState ABORTED => Clazz.GetField<Javax.Print.Attribute.Standard.JobState>("ABORTED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#CANCELED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState CANCELED => Clazz.GetField<Javax.Print.Attribute.Standard.JobState>("CANCELED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#COMPLETED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState COMPLETED => Clazz.GetField<Javax.Print.Attribute.Standard.JobState>("COMPLETED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#PENDING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState PENDING => Clazz.GetField<Javax.Print.Attribute.Standard.JobState>("PENDING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#PENDING_HELD"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState PENDING_HELD => Clazz.GetField<Javax.Print.Attribute.Standard.JobState>("PENDING_HELD");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#PROCESSING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState PROCESSING => Clazz.GetField<Javax.Print.Attribute.Standard.JobState>("PROCESSING");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#PROCESSING_STOPPED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState PROCESSING_STOPPED => Clazz.GetField<Javax.Print.Attribute.Standard.JobState>("PROCESSING_STOPPED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#UNKNOWN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobState UNKNOWN => Clazz.GetField<Javax.Print.Attribute.Standard.JobState>("UNKNOWN");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecute<Java.Lang.Class>("getCategory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobState.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}