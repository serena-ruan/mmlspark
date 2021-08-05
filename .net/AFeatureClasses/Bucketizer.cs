// Copyright (C) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in project root for information.


using System;
using System.Collections.Generic;
using Microsoft.Spark.Interop;
using Microsoft.Spark.Interop.Ipc;
// using Microsoft.Spark.ML.Feature;
using Microsoft.Spark.Sql;
using Microsoft.Spark.Sql.Types;
using mmlspark.dotnet.utils;


namespace featurebase
{
    /// <summary>
    /// <see cref="Bucketizer"/> implements Bucketizer
    /// </summary>
    public class Bucketizer : ScalaModel<Bucketizer>, ScalaMLWritable, ScalaMLReadable<Bucketizer>
    {
        private static readonly string s_bucketizerClassName = "org.apache.spark.ml.feature.Bucketizer";

        /// <summary>
        /// Creates a <see cref="Bucketizer"/> without any parameters.
        /// </summary>
        public Bucketizer() : base(s_bucketizerClassName)
        {
        }

        /// <summary>
        /// Creates a <see cref="Bucketizer"/> with a UID that is used to give the
        /// <see cref="Bucketizer"/> a unique ID.
        /// </summary>
        /// <param name="uid">An immutable unique ID for the object and its derivatives.</param>
        public Bucketizer(string uid) : base(s_bucketizerClassName, uid)
        {
        }

        internal Bucketizer(JvmObjectReference jvmObject) : base(jvmObject)
        {
        }

        /// <summary>
        /// Sets handleInvalid value for <see cref="handleInvalid"/>
        /// </summary>
        /// <param name="handleInvalid">
        /// how to handle invalid entries containing NaN values. Values outside the splits will always be treated as errorsOptions are skip (filter out rows with invalid values), error (throw an error), or keep (keep invalid values in a special additional bucket).
        /// </param>
        /// <returns> New Bucketizer object </returns>
        public Bucketizer SetHandleInvalid(string value) =>
            WrapAsBucketizer(Reference.Invoke("setHandleInvalid", value));
        
        /// <summary>
        /// Sets inputCol value for <see cref="inputCol"/>
        /// </summary>
        /// <param name="inputCol">
        /// input column name
        /// </param>
        /// <returns> New Bucketizer object </returns>
        public Bucketizer SetInputCol(string value) =>
            WrapAsBucketizer(Reference.Invoke("setInputCol", value));
        
        /// <summary>
        /// Sets inputCols value for <see cref="inputCols"/>
        /// </summary>
        /// <param name="inputCols">
        /// input column names
        /// </param>
        /// <returns> New Bucketizer object </returns>
        public Bucketizer SetInputCols(IEnumerable<string> value) =>
            WrapAsBucketizer(Reference.Invoke("setInputCols", value));
        
        /// <summary>
        /// Sets outputCol value for <see cref="outputCol"/>
        /// </summary>
        /// <param name="outputCol">
        /// output column name
        /// </param>
        /// <returns> New Bucketizer object </returns>
        public Bucketizer SetOutputCol(string value) =>
            WrapAsBucketizer(Reference.Invoke("setOutputCol", value));
        
        /// <summary>
        /// Sets outputCols value for <see cref="outputCols"/>
        /// </summary>
        /// <param name="outputCols">
        /// output column names
        /// </param>
        /// <returns> New Bucketizer object </returns>
        public Bucketizer SetOutputCols(IEnumerable<string> value) =>
            WrapAsBucketizer(Reference.Invoke("setOutputCols", value));
        
        /// <summary>
        /// Sets splits value for <see cref="splits"/>
        /// </summary>
        /// <param name="splits">
        /// Split points for mapping continuous features into buckets. With n+1 splits, there are n buckets. A bucket defined by splits x,y holds values in the range [x,y) except the last bucket, which also includes y. The splits should be of length >= 3 and strictly increasing. Values at -inf, inf must be explicitly provided to cover all Double values; otherwise, values outside the splits specified will be treated as errors.
        /// </param>
        /// <returns> New Bucketizer object </returns>
        public Bucketizer SetSplits(IEnumerable<double> value) =>
            WrapAsBucketizer(Reference.Invoke("setSplits", value));
        
        /// <summary>
        /// Sets splitsArray value for <see cref="splitsArray"/>
        /// </summary>
        /// <param name="splitsArray">
        /// The array of split points for mapping continuous features into buckets for multiple columns. For each input column, with n+1 splits, there are n buckets. A bucket defined by splits x,y holds values in the range [x,y) except the last bucket, which also includes y. The splits should be of length >= 3 and strictly increasing. Values at -inf, inf must be explicitly provided to cover all Double values; otherwise, values outside the splits specified will be treated as errors.
        /// </param>
        /// <returns> New Bucketizer object </returns>
        public Bucketizer SetSplitsArray(object value) =>
            WrapAsBucketizer(Reference.Invoke("setSplitsArray", value));

        /// <summary>
        /// Gets handleInvalid value for <see cref="handleInvalid"/>
        /// </summary>
        /// <returns>
        /// handleInvalid: how to handle invalid entries containing NaN values. Values outside the splits will always be treated as errorsOptions are skip (filter out rows with invalid values), error (throw an error), or keep (keep invalid values in a special additional bucket).
        /// </returns>
        public string GetHandleInvalid() =>
            (string)Reference.Invoke("getHandleInvalid");
        
        /// <summary>
        /// Gets inputCol value for <see cref="inputCol"/>
        /// </summary>
        /// <returns>
        /// inputCol: input column name
        /// </returns>
        public string GetInputCol() =>
            (string)Reference.Invoke("getInputCol");
        
        /// <summary>
        /// Gets inputCols value for <see cref="inputCols"/>
        /// </summary>
        /// <returns>
        /// inputCols: input column names
        /// </returns>
        public IEnumerable<string> GetInputCols() =>
            (IEnumerable<string>)Reference.Invoke("getInputCols");
        
        /// <summary>
        /// Gets outputCol value for <see cref="outputCol"/>
        /// </summary>
        /// <returns>
        /// outputCol: output column name
        /// </returns>
        public string GetOutputCol() =>
            (string)Reference.Invoke("getOutputCol");
        
        /// <summary>
        /// Gets outputCols value for <see cref="outputCols"/>
        /// </summary>
        /// <returns>
        /// outputCols: output column names
        /// </returns>
        public IEnumerable<string> GetOutputCols() =>
            (IEnumerable<string>)Reference.Invoke("getOutputCols");
        
        /// <summary>
        /// Gets splits value for <see cref="splits"/>
        /// </summary>
        /// <returns>
        /// splits: Split points for mapping continuous features into buckets. With n+1 splits, there are n buckets. A bucket defined by splits x,y holds values in the range [x,y) except the last bucket, which also includes y. The splits should be of length >= 3 and strictly increasing. Values at -inf, inf must be explicitly provided to cover all Double values; otherwise, values outside the splits specified will be treated as errors.
        /// </returns>
        public IEnumerable<double> GetSplits() =>
            (IEnumerable<double>)Reference.Invoke("getSplits");
        
        /// <summary>
        /// Gets splitsArray value for <see cref="splitsArray"/>
        /// </summary>
        /// <returns>
        /// splitsArray: The array of split points for mapping continuous features into buckets for multiple columns. For each input column, with n+1 splits, there are n buckets. A bucket defined by splits x,y holds values in the range [x,y) except the last bucket, which also includes y. The splits should be of length >= 3 and strictly increasing. Values at -inf, inf must be explicitly provided to cover all Double values; otherwise, values outside the splits specified will be treated as errors.
        /// </returns>
        public object GetSplitsArray() =>
            (object)Reference.Invoke("getSplitsArray");

        /// <summary>
        /// Executes the <see cref="Bucketizer"/> and transforms the DataFrame to include new columns.
        /// </summary>
        /// <param name="dataset">The Dataframe to be transformed.</param>
        /// <returns>
        /// <see cref="DataFrame"/> containing the original data and new columns.
        /// </returns>
        override public DataFrame Transform(DataFrame dataset) =>
            new DataFrame((JvmObjectReference)Reference.Invoke("transform", dataset));
        
        /// <summary>
        /// Check transform validity and derive the output schema from the input schema.
        ///
        /// We check validity for interactions between parameters during transformSchema
        /// and raise an exception if any parameter value is invalid.
        ///
        /// Typical implementation should first conduct verification on schema change and
        /// parameter validity, including complex parameter interaction checks.
        /// </summary>
        /// <param name="schema">
        /// The <see cref="StructType"/> of the <see cref="DataFrame"/> which will be transformed.
        /// </param>
        /// </returns>
        /// The <see cref="StructType"/> of the output schema that would have been derived from the
        /// input schema, if Transform had been called.
        /// </returns>
        public StructType TransformSchema(StructType schema) =>
            new StructType(
                (JvmObjectReference)Reference.Invoke(
                    "transformSchema",
                    DataType.FromJson(Reference.Jvm, schema.Json)));

        /// <summary>
        /// Loads the <see cref="Bucketizer"/> that was previously saved using Save(string).
        /// </summary>
        /// <param name="path">The path the previous <see cref="Bucketizer"/> was saved to</param>
        /// <returns>New <see cref="Bucketizer"/> object, loaded from path.</returns>
        public static Bucketizer Load(string path) => WrapAsBucketizer(
            SparkEnvironment.JvmBridge.CallStaticJavaMethod(s_bucketizerClassName, "load", path));
        
        /// <returns>a <see cref=\"ScalaMLWriter\"/> instance for this ML instance.</returns>
        public ScalaMLWriter Write() => 
            new ScalaMLWriter((JvmObjectReference)Reference.Invoke("write"));

        public ScalaMLReader<Bucketizer> Read() =>
            new ScalaMLReader<Bucketizer>((JvmObjectReference)Reference.Invoke("read"));

        private static Bucketizer WrapAsBucketizer(object obj) =>
            new Bucketizer((JvmObjectReference)obj);


    }
}

        