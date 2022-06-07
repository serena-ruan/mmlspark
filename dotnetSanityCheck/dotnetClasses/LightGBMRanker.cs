// Copyright (C) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in project root for information.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Spark.ML.Feature.Param;
using Microsoft.Spark.Interop;
using Microsoft.Spark.Interop.Ipc;
using Microsoft.Spark.ML.Feature;
using Microsoft.Spark.Sql;
using Microsoft.Spark.Sql.Types;

using SynapseML.Dotnet.Utils;
using Synapse.ML.Lightgbm;

namespace Synapse.ML.Lightgbm
{
    /// <summary>
    /// <see cref="LightGBMRanker"/> implements LightGBMRanker
    /// </summary>
    public class LightGBMRanker : JavaEstimator<LightGBMRankerModel>, IJavaMLWritable, IJavaMLReadable<LightGBMRanker>
    {
        private static readonly string s_className = "com.microsoft.azure.synapse.ml.lightgbm.LightGBMRanker";

        /// <summary>
        /// Creates a <see cref="LightGBMRanker"/> without any parameters.
        /// </summary>
        public LightGBMRanker() : base(s_className)
        {
        }

        /// <summary>
        /// Creates a <see cref="LightGBMRanker"/> with a UID that is used to give the
        /// <see cref="LightGBMRanker"/> a unique ID.
        /// </summary>
        /// <param name="uid">An immutable unique ID for the object and its derivatives.</param>
        public LightGBMRanker(string uid) : base(s_className, uid)
        {
        }

        internal LightGBMRanker(JvmObjectReference jvmObject) : base(jvmObject)
        {
        }

        /// <summary>
        /// Sets baggingFraction value for <see cref="baggingFraction"/>
        /// </summary>
        /// <param name="baggingFraction">
        /// Bagging fraction
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetBaggingFraction(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setBaggingFraction", (object)value));
        
        /// <summary>
        /// Sets baggingFreq value for <see cref="baggingFreq"/>
        /// </summary>
        /// <param name="baggingFreq">
        /// Bagging frequency
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetBaggingFreq(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setBaggingFreq", (object)value));
        
        /// <summary>
        /// Sets baggingSeed value for <see cref="baggingSeed"/>
        /// </summary>
        /// <param name="baggingSeed">
        /// Bagging seed
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetBaggingSeed(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setBaggingSeed", (object)value));
        
        /// <summary>
        /// Sets binSampleCount value for <see cref="binSampleCount"/>
        /// </summary>
        /// <param name="binSampleCount">
        /// Number of samples considered at computing histogram bins
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetBinSampleCount(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setBinSampleCount", (object)value));
        
        /// <summary>
        /// Sets boostFromAverage value for <see cref="boostFromAverage"/>
        /// </summary>
        /// <param name="boostFromAverage">
        /// Adjusts initial score to the mean of labels for faster convergence
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetBoostFromAverage(bool value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setBoostFromAverage", (object)value));
        
        /// <summary>
        /// Sets boostingType value for <see cref="boostingType"/>
        /// </summary>
        /// <param name="boostingType">
        /// Default gbdt = traditional Gradient Boosting Decision Tree. Options are: gbdt, gbrt, rf (Random Forest), random_forest, dart (Dropouts meet Multiple Additive Regression Trees), goss (Gradient-based One-Side Sampling). 
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetBoostingType(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setBoostingType", (object)value));
        
        /// <summary>
        /// Sets categoricalSlotIndexes value for <see cref="categoricalSlotIndexes"/>
        /// </summary>
        /// <param name="categoricalSlotIndexes">
        /// List of categorical column indexes, the slot index in the features column
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetCategoricalSlotIndexes(int[] value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setCategoricalSlotIndexes", (object)value));
        
        /// <summary>
        /// Sets categoricalSlotNames value for <see cref="categoricalSlotNames"/>
        /// </summary>
        /// <param name="categoricalSlotNames">
        /// List of categorical column slot names, the slot name in the features column
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetCategoricalSlotNames(string[] value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setCategoricalSlotNames", (object)value));
        
        /// <summary>
        /// Sets chunkSize value for <see cref="chunkSize"/>
        /// </summary>
        /// <param name="chunkSize">
        /// Advanced parameter to specify the chunk size for copying Java data to native.  If set too high, memory may be wasted, but if set too low, performance may be reduced during data copy.If dataset size is known beforehand, set to the number of rows in the dataset.
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetChunkSize(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setChunkSize", (object)value));
        
        /// <summary>
        /// Sets defaultListenPort value for <see cref="defaultListenPort"/>
        /// </summary>
        /// <param name="defaultListenPort">
        /// The default listen port on executors, used for testing
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetDefaultListenPort(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setDefaultListenPort", (object)value));
        
        /// <summary>
        /// Sets driverListenPort value for <see cref="driverListenPort"/>
        /// </summary>
        /// <param name="driverListenPort">
        /// The listen port on a driver. Default value is 0 (random)
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetDriverListenPort(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setDriverListenPort", (object)value));
        
        /// <summary>
        /// Sets dropRate value for <see cref="dropRate"/>
        /// </summary>
        /// <param name="dropRate">
        /// Dropout rate: a fraction of previous trees to drop during the dropout
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetDropRate(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setDropRate", (object)value));
        
        /// <summary>
        /// Sets earlyStoppingRound value for <see cref="earlyStoppingRound"/>
        /// </summary>
        /// <param name="earlyStoppingRound">
        /// Early stopping round
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetEarlyStoppingRound(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setEarlyStoppingRound", (object)value));
        
        /// <summary>
        /// Sets evalAt value for <see cref="evalAt"/>
        /// </summary>
        /// <param name="evalAt">
        /// NDCG and MAP evaluation positions, separated by comma
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetEvalAt(int[] value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setEvalAt", (object)value));
        
        /// <summary>
        /// Sets featureFraction value for <see cref="featureFraction"/>
        /// </summary>
        /// <param name="featureFraction">
        /// Feature fraction
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetFeatureFraction(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setFeatureFraction", (object)value));
        
        /// <summary>
        /// Sets featuresCol value for <see cref="featuresCol"/>
        /// </summary>
        /// <param name="featuresCol">
        /// features column name
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetFeaturesCol(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setFeaturesCol", (object)value));
        
        /// <summary>
        /// Sets featuresShapCol value for <see cref="featuresShapCol"/>
        /// </summary>
        /// <param name="featuresShapCol">
        /// Output SHAP vector column name after prediction containing the feature contribution values
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetFeaturesShapCol(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setFeaturesShapCol", (object)value));
        
        /// <summary>
        /// Sets fobj value for <see cref="fobj"/>
        /// </summary>
        /// <param name="fobj">
        /// Customized objective function. Should accept two parameters: preds, train_data, and return (grad, hess).
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetFobj(object value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setFobj", (object)value));
        
        /// <summary>
        /// Sets groupCol value for <see cref="groupCol"/>
        /// </summary>
        /// <param name="groupCol">
        /// The name of the group column
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetGroupCol(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setGroupCol", (object)value));
        
        /// <summary>
        /// Sets improvementTolerance value for <see cref="improvementTolerance"/>
        /// </summary>
        /// <param name="improvementTolerance">
        /// Tolerance to consider improvement in metric
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetImprovementTolerance(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setImprovementTolerance", (object)value));
        
        /// <summary>
        /// Sets initScoreCol value for <see cref="initScoreCol"/>
        /// </summary>
        /// <param name="initScoreCol">
        /// The name of the initial score column, used for continued training
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetInitScoreCol(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setInitScoreCol", (object)value));
        
        /// <summary>
        /// Sets isProvideTrainingMetric value for <see cref="isProvideTrainingMetric"/>
        /// </summary>
        /// <param name="isProvideTrainingMetric">
        /// Whether output metric result over training dataset.
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetIsProvideTrainingMetric(bool value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setIsProvideTrainingMetric", (object)value));
        
        /// <summary>
        /// Sets labelCol value for <see cref="labelCol"/>
        /// </summary>
        /// <param name="labelCol">
        /// label column name
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetLabelCol(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setLabelCol", (object)value));
        
        /// <summary>
        /// Sets labelGain value for <see cref="labelGain"/>
        /// </summary>
        /// <param name="labelGain">
        /// graded relevance for each label in NDCG
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetLabelGain(double[] value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setLabelGain", (object)value));
        
        /// <summary>
        /// Sets lambdaL1 value for <see cref="lambdaL1"/>
        /// </summary>
        /// <param name="lambdaL1">
        /// L1 regularization
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetLambdaL1(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setLambdaL1", (object)value));
        
        /// <summary>
        /// Sets lambdaL2 value for <see cref="lambdaL2"/>
        /// </summary>
        /// <param name="lambdaL2">
        /// L2 regularization
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetLambdaL2(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setLambdaL2", (object)value));
        
        /// <summary>
        /// Sets leafPredictionCol value for <see cref="leafPredictionCol"/>
        /// </summary>
        /// <param name="leafPredictionCol">
        /// Predicted leaf indices's column name
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetLeafPredictionCol(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setLeafPredictionCol", (object)value));
        
        /// <summary>
        /// Sets learningRate value for <see cref="learningRate"/>
        /// </summary>
        /// <param name="learningRate">
        /// Learning rate or shrinkage rate
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetLearningRate(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setLearningRate", (object)value));
        
        /// <summary>
        /// Sets matrixType value for <see cref="matrixType"/>
        /// </summary>
        /// <param name="matrixType">
        /// Advanced parameter to specify whether the native lightgbm matrix constructed should be sparse or dense.  Values can be auto, sparse or dense. Default value is auto, which samples first ten rows to determine type.
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMatrixType(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMatrixType", (object)value));
        
        /// <summary>
        /// Sets maxBin value for <see cref="maxBin"/>
        /// </summary>
        /// <param name="maxBin">
        /// Max bin
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMaxBin(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMaxBin", (object)value));
        
        /// <summary>
        /// Sets maxBinByFeature value for <see cref="maxBinByFeature"/>
        /// </summary>
        /// <param name="maxBinByFeature">
        /// Max number of bins for each feature
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMaxBinByFeature(int[] value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMaxBinByFeature", (object)value));
        
        /// <summary>
        /// Sets maxDeltaStep value for <see cref="maxDeltaStep"/>
        /// </summary>
        /// <param name="maxDeltaStep">
        /// Used to limit the max output of tree leaves
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMaxDeltaStep(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMaxDeltaStep", (object)value));
        
        /// <summary>
        /// Sets maxDepth value for <see cref="maxDepth"/>
        /// </summary>
        /// <param name="maxDepth">
        /// Max depth
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMaxDepth(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMaxDepth", (object)value));
        
        /// <summary>
        /// Sets maxDrop value for <see cref="maxDrop"/>
        /// </summary>
        /// <param name="maxDrop">
        /// Max number of dropped trees during one boosting iteration
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMaxDrop(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMaxDrop", (object)value));
        
        /// <summary>
        /// Sets maxPosition value for <see cref="maxPosition"/>
        /// </summary>
        /// <param name="maxPosition">
        /// optimized NDCG at this position
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMaxPosition(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMaxPosition", (object)value));
        
        /// <summary>
        /// Sets metric value for <see cref="metric"/>
        /// </summary>
        /// <param name="metric">
        /// Metrics to be evaluated on the evaluation data.  Options are: empty string or not specified means that metric corresponding to specified objective will be used (this is possible only for pre-defined objective functions, otherwise no evaluation metric will be added). None (string, not a None value) means that no metric will be registered, aliases: na, null, custom. l1, absolute loss, aliases: mean_absolute_error, mae, regression_l1. l2, square loss, aliases: mean_squared_error, mse, regression_l2, regression. rmse, root square loss, aliases: root_mean_squared_error, l2_root. quantile, Quantile regression. mape, MAPE loss, aliases: mean_absolute_percentage_error. huber, Huber loss. fair, Fair loss. poisson, negative log-likelihood for Poisson regression. gamma, negative log-likelihood for Gamma regression. gamma_deviance, residual deviance for Gamma regression. tweedie, negative log-likelihood for Tweedie regression. ndcg, NDCG, aliases: lambdarank. map, MAP, aliases: mean_average_precision. auc, AUC. binary_logloss, log loss, aliases: binary. binary_error, for one sample: 0 for correct classification, 1 for error classification. multi_logloss, log loss for multi-class classification, aliases: multiclass, softmax, multiclassova, multiclass_ova, ova, ovr. multi_error, error rate for multi-class classification. cross_entropy, cross-entropy (with optional linear weights), aliases: xentropy. cross_entropy_lambda, intensity-weighted cross-entropy, aliases: xentlambda. kullback_leibler, Kullback-Leibler divergence, aliases: kldiv. 
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMetric(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMetric", (object)value));
        
        /// <summary>
        /// Sets minDataInLeaf value for <see cref="minDataInLeaf"/>
        /// </summary>
        /// <param name="minDataInLeaf">
        /// Minimal number of data in one leaf. Can be used to deal with over-fitting.
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMinDataInLeaf(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMinDataInLeaf", (object)value));
        
        /// <summary>
        /// Sets minGainToSplit value for <see cref="minGainToSplit"/>
        /// </summary>
        /// <param name="minGainToSplit">
        /// The minimal gain to perform split
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMinGainToSplit(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMinGainToSplit", (object)value));
        
        /// <summary>
        /// Sets minSumHessianInLeaf value for <see cref="minSumHessianInLeaf"/>
        /// </summary>
        /// <param name="minSumHessianInLeaf">
        /// Minimal sum hessian in one leaf
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetMinSumHessianInLeaf(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setMinSumHessianInLeaf", (object)value));
        
        /// <summary>
        /// Sets modelString value for <see cref="modelString"/>
        /// </summary>
        /// <param name="modelString">
        /// LightGBM model to retrain
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetModelString(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setModelString", (object)value));
        
        /// <summary>
        /// Sets negBaggingFraction value for <see cref="negBaggingFraction"/>
        /// </summary>
        /// <param name="negBaggingFraction">
        /// Negative Bagging fraction
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetNegBaggingFraction(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setNegBaggingFraction", (object)value));
        
        /// <summary>
        /// Sets numBatches value for <see cref="numBatches"/>
        /// </summary>
        /// <param name="numBatches">
        /// If greater than 0, splits data into separate batches during training
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetNumBatches(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setNumBatches", (object)value));
        
        /// <summary>
        /// Sets numIterations value for <see cref="numIterations"/>
        /// </summary>
        /// <param name="numIterations">
        /// Number of iterations, LightGBM constructs num_class * num_iterations trees
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetNumIterations(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setNumIterations", (object)value));
        
        /// <summary>
        /// Sets numLeaves value for <see cref="numLeaves"/>
        /// </summary>
        /// <param name="numLeaves">
        /// Number of leaves
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetNumLeaves(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setNumLeaves", (object)value));
        
        /// <summary>
        /// Sets numTasks value for <see cref="numTasks"/>
        /// </summary>
        /// <param name="numTasks">
        /// Advanced parameter to specify the number of tasks.  SynapseML tries to guess this based on cluster configuration, but this parameter can be used to override.
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetNumTasks(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setNumTasks", (object)value));
        
        /// <summary>
        /// Sets numThreads value for <see cref="numThreads"/>
        /// </summary>
        /// <param name="numThreads">
        /// Number of threads for LightGBM. For the best speed, set this to the number of real CPU cores.
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetNumThreads(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setNumThreads", (object)value));
        
        /// <summary>
        /// Sets objective value for <see cref="objective"/>
        /// </summary>
        /// <param name="objective">
        /// The Objective. For regression applications, this can be: regression_l2, regression_l1, huber, fair, poisson, quantile, mape, gamma or tweedie. For classification applications, this can be: binary, multiclass, or multiclassova. 
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetObjective(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setObjective", (object)value));
        
        /// <summary>
        /// Sets parallelism value for <see cref="parallelism"/>
        /// </summary>
        /// <param name="parallelism">
        /// Tree learner parallelism, can be set to data_parallel or voting_parallel
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetParallelism(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setParallelism", (object)value));
        
        /// <summary>
        /// Sets posBaggingFraction value for <see cref="posBaggingFraction"/>
        /// </summary>
        /// <param name="posBaggingFraction">
        /// Positive Bagging fraction
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetPosBaggingFraction(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setPosBaggingFraction", (object)value));
        
        /// <summary>
        /// Sets predictDisableShapeCheck value for <see cref="predictDisableShapeCheck"/>
        /// </summary>
        /// <param name="predictDisableShapeCheck">
        /// control whether or not LightGBM raises an error when you try to predict on data with a different number of features than the training data
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetPredictDisableShapeCheck(bool value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setPredictDisableShapeCheck", (object)value));
        
        /// <summary>
        /// Sets predictionCol value for <see cref="predictionCol"/>
        /// </summary>
        /// <param name="predictionCol">
        /// prediction column name
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetPredictionCol(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setPredictionCol", (object)value));
        
        /// <summary>
        /// Sets repartitionByGroupingColumn value for <see cref="repartitionByGroupingColumn"/>
        /// </summary>
        /// <param name="repartitionByGroupingColumn">
        /// Repartition training data according to grouping column, on by default.
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetRepartitionByGroupingColumn(bool value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setRepartitionByGroupingColumn", (object)value));
        
        /// <summary>
        /// Sets skipDrop value for <see cref="skipDrop"/>
        /// </summary>
        /// <param name="skipDrop">
        /// Probability of skipping the dropout procedure during a boosting iteration
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetSkipDrop(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setSkipDrop", (object)value));
        
        /// <summary>
        /// Sets slotNames value for <see cref="slotNames"/>
        /// </summary>
        /// <param name="slotNames">
        /// List of slot names in the features column
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetSlotNames(string[] value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setSlotNames", (object)value));
        
        /// <summary>
        /// Sets timeout value for <see cref="timeout"/>
        /// </summary>
        /// <param name="timeout">
        /// Timeout in seconds
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetTimeout(double value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setTimeout", (object)value));
        
        /// <summary>
        /// Sets topK value for <see cref="topK"/>
        /// </summary>
        /// <param name="topK">
        /// The top_k value used in Voting parallel, set this to larger value for more accurate result, but it will slow down the training speed. It should be greater than 0
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetTopK(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setTopK", (object)value));
        
        /// <summary>
        /// Sets uniformDrop value for <see cref="uniformDrop"/>
        /// </summary>
        /// <param name="uniformDrop">
        /// Set this to true to use uniform drop in dart mode
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetUniformDrop(bool value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setUniformDrop", (object)value));
        
        /// <summary>
        /// Sets useBarrierExecutionMode value for <see cref="useBarrierExecutionMode"/>
        /// </summary>
        /// <param name="useBarrierExecutionMode">
        /// Barrier execution mode which uses a barrier stage, off by default.
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetUseBarrierExecutionMode(bool value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setUseBarrierExecutionMode", (object)value));
        
        /// <summary>
        /// Sets useSingleDatasetMode value for <see cref="useSingleDatasetMode"/>
        /// </summary>
        /// <param name="useSingleDatasetMode">
        /// Use single dataset execution mode to create a single native dataset per executor (singleton) to reduce memory and communication overhead. Note this is disabled when running spark in local mode.
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetUseSingleDatasetMode(bool value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setUseSingleDatasetMode", (object)value));
        
        /// <summary>
        /// Sets validationIndicatorCol value for <see cref="validationIndicatorCol"/>
        /// </summary>
        /// <param name="validationIndicatorCol">
        /// Indicates whether the row is for training or validation
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetValidationIndicatorCol(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setValidationIndicatorCol", (object)value));
        
        /// <summary>
        /// Sets verbosity value for <see cref="verbosity"/>
        /// </summary>
        /// <param name="verbosity">
        /// Verbosity where lt 0 is Fatal, eq 0 is Error, eq 1 is Info, gt 1 is Debug
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetVerbosity(int value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setVerbosity", (object)value));
        
        /// <summary>
        /// Sets weightCol value for <see cref="weightCol"/>
        /// </summary>
        /// <param name="weightCol">
        /// The name of the weight column
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetWeightCol(string value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setWeightCol", (object)value));
        
        /// <summary>
        /// Sets xgboostDartMode value for <see cref="xgboostDartMode"/>
        /// </summary>
        /// <param name="xgboostDartMode">
        /// Set this to true to use xgboost dart mode
        /// </param>
        /// <returns> New LightGBMRanker object </returns>
        public LightGBMRanker SetXGBoostDartMode(bool value) =>
            WrapAsLightGBMRanker(Reference.Invoke("setXGBoostDartMode", (object)value));

        
        /// <summary>
        /// Gets baggingFraction value for <see cref="baggingFraction"/>
        /// </summary>
        /// <returns>
        /// baggingFraction: Bagging fraction
        /// </returns>
        public double GetBaggingFraction() =>
            (double)Reference.Invoke("getBaggingFraction");
        
        
        /// <summary>
        /// Gets baggingFreq value for <see cref="baggingFreq"/>
        /// </summary>
        /// <returns>
        /// baggingFreq: Bagging frequency
        /// </returns>
        public int GetBaggingFreq() =>
            (int)Reference.Invoke("getBaggingFreq");
        
        
        /// <summary>
        /// Gets baggingSeed value for <see cref="baggingSeed"/>
        /// </summary>
        /// <returns>
        /// baggingSeed: Bagging seed
        /// </returns>
        public int GetBaggingSeed() =>
            (int)Reference.Invoke("getBaggingSeed");
        
        
        /// <summary>
        /// Gets binSampleCount value for <see cref="binSampleCount"/>
        /// </summary>
        /// <returns>
        /// binSampleCount: Number of samples considered at computing histogram bins
        /// </returns>
        public int GetBinSampleCount() =>
            (int)Reference.Invoke("getBinSampleCount");
        
        
        /// <summary>
        /// Gets boostFromAverage value for <see cref="boostFromAverage"/>
        /// </summary>
        /// <returns>
        /// boostFromAverage: Adjusts initial score to the mean of labels for faster convergence
        /// </returns>
        public bool GetBoostFromAverage() =>
            (bool)Reference.Invoke("getBoostFromAverage");
        
        
        /// <summary>
        /// Gets boostingType value for <see cref="boostingType"/>
        /// </summary>
        /// <returns>
        /// boostingType: Default gbdt = traditional Gradient Boosting Decision Tree. Options are: gbdt, gbrt, rf (Random Forest), random_forest, dart (Dropouts meet Multiple Additive Regression Trees), goss (Gradient-based One-Side Sampling). 
        /// </returns>
        public string GetBoostingType() =>
            (string)Reference.Invoke("getBoostingType");
        
        
        /// <summary>
        /// Gets categoricalSlotIndexes value for <see cref="categoricalSlotIndexes"/>
        /// </summary>
        /// <returns>
        /// categoricalSlotIndexes: List of categorical column indexes, the slot index in the features column
        /// </returns>
        public int[] GetCategoricalSlotIndexes() =>
            (int[])Reference.Invoke("getCategoricalSlotIndexes");
        
        
        /// <summary>
        /// Gets categoricalSlotNames value for <see cref="categoricalSlotNames"/>
        /// </summary>
        /// <returns>
        /// categoricalSlotNames: List of categorical column slot names, the slot name in the features column
        /// </returns>
        public string[] GetCategoricalSlotNames() =>
            (string[])Reference.Invoke("getCategoricalSlotNames");
        
        
        /// <summary>
        /// Gets chunkSize value for <see cref="chunkSize"/>
        /// </summary>
        /// <returns>
        /// chunkSize: Advanced parameter to specify the chunk size for copying Java data to native.  If set too high, memory may be wasted, but if set too low, performance may be reduced during data copy.If dataset size is known beforehand, set to the number of rows in the dataset.
        /// </returns>
        public int GetChunkSize() =>
            (int)Reference.Invoke("getChunkSize");
        
        
        /// <summary>
        /// Gets defaultListenPort value for <see cref="defaultListenPort"/>
        /// </summary>
        /// <returns>
        /// defaultListenPort: The default listen port on executors, used for testing
        /// </returns>
        public int GetDefaultListenPort() =>
            (int)Reference.Invoke("getDefaultListenPort");
        
        
        /// <summary>
        /// Gets driverListenPort value for <see cref="driverListenPort"/>
        /// </summary>
        /// <returns>
        /// driverListenPort: The listen port on a driver. Default value is 0 (random)
        /// </returns>
        public int GetDriverListenPort() =>
            (int)Reference.Invoke("getDriverListenPort");
        
        
        /// <summary>
        /// Gets dropRate value for <see cref="dropRate"/>
        /// </summary>
        /// <returns>
        /// dropRate: Dropout rate: a fraction of previous trees to drop during the dropout
        /// </returns>
        public double GetDropRate() =>
            (double)Reference.Invoke("getDropRate");
        
        
        /// <summary>
        /// Gets earlyStoppingRound value for <see cref="earlyStoppingRound"/>
        /// </summary>
        /// <returns>
        /// earlyStoppingRound: Early stopping round
        /// </returns>
        public int GetEarlyStoppingRound() =>
            (int)Reference.Invoke("getEarlyStoppingRound");
        
        
        /// <summary>
        /// Gets evalAt value for <see cref="evalAt"/>
        /// </summary>
        /// <returns>
        /// evalAt: NDCG and MAP evaluation positions, separated by comma
        /// </returns>
        public int[] GetEvalAt() =>
            (int[])Reference.Invoke("getEvalAt");
        
        
        /// <summary>
        /// Gets featureFraction value for <see cref="featureFraction"/>
        /// </summary>
        /// <returns>
        /// featureFraction: Feature fraction
        /// </returns>
        public double GetFeatureFraction() =>
            (double)Reference.Invoke("getFeatureFraction");
        
        
        /// <summary>
        /// Gets featuresCol value for <see cref="featuresCol"/>
        /// </summary>
        /// <returns>
        /// featuresCol: features column name
        /// </returns>
        public string GetFeaturesCol() =>
            (string)Reference.Invoke("getFeaturesCol");
        
        
        /// <summary>
        /// Gets featuresShapCol value for <see cref="featuresShapCol"/>
        /// </summary>
        /// <returns>
        /// featuresShapCol: Output SHAP vector column name after prediction containing the feature contribution values
        /// </returns>
        public string GetFeaturesShapCol() =>
            (string)Reference.Invoke("getFeaturesShapCol");
        
        
        /// <summary>
        /// Gets fobj value for <see cref="fobj"/>
        /// </summary>
        /// <returns>
        /// fobj: Customized objective function. Should accept two parameters: preds, train_data, and return (grad, hess).
        /// </returns>
        public object GetFobj() => Reference.Invoke("getFobj");
        
        
        /// <summary>
        /// Gets groupCol value for <see cref="groupCol"/>
        /// </summary>
        /// <returns>
        /// groupCol: The name of the group column
        /// </returns>
        public string GetGroupCol() =>
            (string)Reference.Invoke("getGroupCol");
        
        
        /// <summary>
        /// Gets improvementTolerance value for <see cref="improvementTolerance"/>
        /// </summary>
        /// <returns>
        /// improvementTolerance: Tolerance to consider improvement in metric
        /// </returns>
        public double GetImprovementTolerance() =>
            (double)Reference.Invoke("getImprovementTolerance");
        
        
        /// <summary>
        /// Gets initScoreCol value for <see cref="initScoreCol"/>
        /// </summary>
        /// <returns>
        /// initScoreCol: The name of the initial score column, used for continued training
        /// </returns>
        public string GetInitScoreCol() =>
            (string)Reference.Invoke("getInitScoreCol");
        
        
        /// <summary>
        /// Gets isProvideTrainingMetric value for <see cref="isProvideTrainingMetric"/>
        /// </summary>
        /// <returns>
        /// isProvideTrainingMetric: Whether output metric result over training dataset.
        /// </returns>
        public bool GetIsProvideTrainingMetric() =>
            (bool)Reference.Invoke("getIsProvideTrainingMetric");
        
        
        /// <summary>
        /// Gets labelCol value for <see cref="labelCol"/>
        /// </summary>
        /// <returns>
        /// labelCol: label column name
        /// </returns>
        public string GetLabelCol() =>
            (string)Reference.Invoke("getLabelCol");
        
        
        /// <summary>
        /// Gets labelGain value for <see cref="labelGain"/>
        /// </summary>
        /// <returns>
        /// labelGain: graded relevance for each label in NDCG
        /// </returns>
        public double[] GetLabelGain() =>
            (double[])Reference.Invoke("getLabelGain");
        
        
        /// <summary>
        /// Gets lambdaL1 value for <see cref="lambdaL1"/>
        /// </summary>
        /// <returns>
        /// lambdaL1: L1 regularization
        /// </returns>
        public double GetLambdaL1() =>
            (double)Reference.Invoke("getLambdaL1");
        
        
        /// <summary>
        /// Gets lambdaL2 value for <see cref="lambdaL2"/>
        /// </summary>
        /// <returns>
        /// lambdaL2: L2 regularization
        /// </returns>
        public double GetLambdaL2() =>
            (double)Reference.Invoke("getLambdaL2");
        
        
        /// <summary>
        /// Gets leafPredictionCol value for <see cref="leafPredictionCol"/>
        /// </summary>
        /// <returns>
        /// leafPredictionCol: Predicted leaf indices's column name
        /// </returns>
        public string GetLeafPredictionCol() =>
            (string)Reference.Invoke("getLeafPredictionCol");
        
        
        /// <summary>
        /// Gets learningRate value for <see cref="learningRate"/>
        /// </summary>
        /// <returns>
        /// learningRate: Learning rate or shrinkage rate
        /// </returns>
        public double GetLearningRate() =>
            (double)Reference.Invoke("getLearningRate");
        
        
        /// <summary>
        /// Gets matrixType value for <see cref="matrixType"/>
        /// </summary>
        /// <returns>
        /// matrixType: Advanced parameter to specify whether the native lightgbm matrix constructed should be sparse or dense.  Values can be auto, sparse or dense. Default value is auto, which samples first ten rows to determine type.
        /// </returns>
        public string GetMatrixType() =>
            (string)Reference.Invoke("getMatrixType");
        
        
        /// <summary>
        /// Gets maxBin value for <see cref="maxBin"/>
        /// </summary>
        /// <returns>
        /// maxBin: Max bin
        /// </returns>
        public int GetMaxBin() =>
            (int)Reference.Invoke("getMaxBin");
        
        
        /// <summary>
        /// Gets maxBinByFeature value for <see cref="maxBinByFeature"/>
        /// </summary>
        /// <returns>
        /// maxBinByFeature: Max number of bins for each feature
        /// </returns>
        public int[] GetMaxBinByFeature() =>
            (int[])Reference.Invoke("getMaxBinByFeature");
        
        
        /// <summary>
        /// Gets maxDeltaStep value for <see cref="maxDeltaStep"/>
        /// </summary>
        /// <returns>
        /// maxDeltaStep: Used to limit the max output of tree leaves
        /// </returns>
        public double GetMaxDeltaStep() =>
            (double)Reference.Invoke("getMaxDeltaStep");
        
        
        /// <summary>
        /// Gets maxDepth value for <see cref="maxDepth"/>
        /// </summary>
        /// <returns>
        /// maxDepth: Max depth
        /// </returns>
        public int GetMaxDepth() =>
            (int)Reference.Invoke("getMaxDepth");
        
        
        /// <summary>
        /// Gets maxDrop value for <see cref="maxDrop"/>
        /// </summary>
        /// <returns>
        /// maxDrop: Max number of dropped trees during one boosting iteration
        /// </returns>
        public int GetMaxDrop() =>
            (int)Reference.Invoke("getMaxDrop");
        
        
        /// <summary>
        /// Gets maxPosition value for <see cref="maxPosition"/>
        /// </summary>
        /// <returns>
        /// maxPosition: optimized NDCG at this position
        /// </returns>
        public int GetMaxPosition() =>
            (int)Reference.Invoke("getMaxPosition");
        
        
        /// <summary>
        /// Gets metric value for <see cref="metric"/>
        /// </summary>
        /// <returns>
        /// metric: Metrics to be evaluated on the evaluation data.  Options are: empty string or not specified means that metric corresponding to specified objective will be used (this is possible only for pre-defined objective functions, otherwise no evaluation metric will be added). None (string, not a None value) means that no metric will be registered, aliases: na, null, custom. l1, absolute loss, aliases: mean_absolute_error, mae, regression_l1. l2, square loss, aliases: mean_squared_error, mse, regression_l2, regression. rmse, root square loss, aliases: root_mean_squared_error, l2_root. quantile, Quantile regression. mape, MAPE loss, aliases: mean_absolute_percentage_error. huber, Huber loss. fair, Fair loss. poisson, negative log-likelihood for Poisson regression. gamma, negative log-likelihood for Gamma regression. gamma_deviance, residual deviance for Gamma regression. tweedie, negative log-likelihood for Tweedie regression. ndcg, NDCG, aliases: lambdarank. map, MAP, aliases: mean_average_precision. auc, AUC. binary_logloss, log loss, aliases: binary. binary_error, for one sample: 0 for correct classification, 1 for error classification. multi_logloss, log loss for multi-class classification, aliases: multiclass, softmax, multiclassova, multiclass_ova, ova, ovr. multi_error, error rate for multi-class classification. cross_entropy, cross-entropy (with optional linear weights), aliases: xentropy. cross_entropy_lambda, intensity-weighted cross-entropy, aliases: xentlambda. kullback_leibler, Kullback-Leibler divergence, aliases: kldiv. 
        /// </returns>
        public string GetMetric() =>
            (string)Reference.Invoke("getMetric");
        
        
        /// <summary>
        /// Gets minDataInLeaf value for <see cref="minDataInLeaf"/>
        /// </summary>
        /// <returns>
        /// minDataInLeaf: Minimal number of data in one leaf. Can be used to deal with over-fitting.
        /// </returns>
        public int GetMinDataInLeaf() =>
            (int)Reference.Invoke("getMinDataInLeaf");
        
        
        /// <summary>
        /// Gets minGainToSplit value for <see cref="minGainToSplit"/>
        /// </summary>
        /// <returns>
        /// minGainToSplit: The minimal gain to perform split
        /// </returns>
        public double GetMinGainToSplit() =>
            (double)Reference.Invoke("getMinGainToSplit");
        
        
        /// <summary>
        /// Gets minSumHessianInLeaf value for <see cref="minSumHessianInLeaf"/>
        /// </summary>
        /// <returns>
        /// minSumHessianInLeaf: Minimal sum hessian in one leaf
        /// </returns>
        public double GetMinSumHessianInLeaf() =>
            (double)Reference.Invoke("getMinSumHessianInLeaf");
        
        
        /// <summary>
        /// Gets modelString value for <see cref="modelString"/>
        /// </summary>
        /// <returns>
        /// modelString: LightGBM model to retrain
        /// </returns>
        public string GetModelString() =>
            (string)Reference.Invoke("getModelString");
        
        
        /// <summary>
        /// Gets negBaggingFraction value for <see cref="negBaggingFraction"/>
        /// </summary>
        /// <returns>
        /// negBaggingFraction: Negative Bagging fraction
        /// </returns>
        public double GetNegBaggingFraction() =>
            (double)Reference.Invoke("getNegBaggingFraction");
        
        
        /// <summary>
        /// Gets numBatches value for <see cref="numBatches"/>
        /// </summary>
        /// <returns>
        /// numBatches: If greater than 0, splits data into separate batches during training
        /// </returns>
        public int GetNumBatches() =>
            (int)Reference.Invoke("getNumBatches");
        
        
        /// <summary>
        /// Gets numIterations value for <see cref="numIterations"/>
        /// </summary>
        /// <returns>
        /// numIterations: Number of iterations, LightGBM constructs num_class * num_iterations trees
        /// </returns>
        public int GetNumIterations() =>
            (int)Reference.Invoke("getNumIterations");
        
        
        /// <summary>
        /// Gets numLeaves value for <see cref="numLeaves"/>
        /// </summary>
        /// <returns>
        /// numLeaves: Number of leaves
        /// </returns>
        public int GetNumLeaves() =>
            (int)Reference.Invoke("getNumLeaves");
        
        
        /// <summary>
        /// Gets numTasks value for <see cref="numTasks"/>
        /// </summary>
        /// <returns>
        /// numTasks: Advanced parameter to specify the number of tasks.  SynapseML tries to guess this based on cluster configuration, but this parameter can be used to override.
        /// </returns>
        public int GetNumTasks() =>
            (int)Reference.Invoke("getNumTasks");
        
        
        /// <summary>
        /// Gets numThreads value for <see cref="numThreads"/>
        /// </summary>
        /// <returns>
        /// numThreads: Number of threads for LightGBM. For the best speed, set this to the number of real CPU cores.
        /// </returns>
        public int GetNumThreads() =>
            (int)Reference.Invoke("getNumThreads");
        
        
        /// <summary>
        /// Gets objective value for <see cref="objective"/>
        /// </summary>
        /// <returns>
        /// objective: The Objective. For regression applications, this can be: regression_l2, regression_l1, huber, fair, poisson, quantile, mape, gamma or tweedie. For classification applications, this can be: binary, multiclass, or multiclassova. 
        /// </returns>
        public string GetObjective() =>
            (string)Reference.Invoke("getObjective");
        
        
        /// <summary>
        /// Gets parallelism value for <see cref="parallelism"/>
        /// </summary>
        /// <returns>
        /// parallelism: Tree learner parallelism, can be set to data_parallel or voting_parallel
        /// </returns>
        public string GetParallelism() =>
            (string)Reference.Invoke("getParallelism");
        
        
        /// <summary>
        /// Gets posBaggingFraction value for <see cref="posBaggingFraction"/>
        /// </summary>
        /// <returns>
        /// posBaggingFraction: Positive Bagging fraction
        /// </returns>
        public double GetPosBaggingFraction() =>
            (double)Reference.Invoke("getPosBaggingFraction");
        
        
        /// <summary>
        /// Gets predictDisableShapeCheck value for <see cref="predictDisableShapeCheck"/>
        /// </summary>
        /// <returns>
        /// predictDisableShapeCheck: control whether or not LightGBM raises an error when you try to predict on data with a different number of features than the training data
        /// </returns>
        public bool GetPredictDisableShapeCheck() =>
            (bool)Reference.Invoke("getPredictDisableShapeCheck");
        
        
        /// <summary>
        /// Gets predictionCol value for <see cref="predictionCol"/>
        /// </summary>
        /// <returns>
        /// predictionCol: prediction column name
        /// </returns>
        public string GetPredictionCol() =>
            (string)Reference.Invoke("getPredictionCol");
        
        
        /// <summary>
        /// Gets repartitionByGroupingColumn value for <see cref="repartitionByGroupingColumn"/>
        /// </summary>
        /// <returns>
        /// repartitionByGroupingColumn: Repartition training data according to grouping column, on by default.
        /// </returns>
        public bool GetRepartitionByGroupingColumn() =>
            (bool)Reference.Invoke("getRepartitionByGroupingColumn");
        
        
        /// <summary>
        /// Gets skipDrop value for <see cref="skipDrop"/>
        /// </summary>
        /// <returns>
        /// skipDrop: Probability of skipping the dropout procedure during a boosting iteration
        /// </returns>
        public double GetSkipDrop() =>
            (double)Reference.Invoke("getSkipDrop");
        
        
        /// <summary>
        /// Gets slotNames value for <see cref="slotNames"/>
        /// </summary>
        /// <returns>
        /// slotNames: List of slot names in the features column
        /// </returns>
        public string[] GetSlotNames() =>
            (string[])Reference.Invoke("getSlotNames");
        
        
        /// <summary>
        /// Gets timeout value for <see cref="timeout"/>
        /// </summary>
        /// <returns>
        /// timeout: Timeout in seconds
        /// </returns>
        public double GetTimeout() =>
            (double)Reference.Invoke("getTimeout");
        
        
        /// <summary>
        /// Gets topK value for <see cref="topK"/>
        /// </summary>
        /// <returns>
        /// topK: The top_k value used in Voting parallel, set this to larger value for more accurate result, but it will slow down the training speed. It should be greater than 0
        /// </returns>
        public int GetTopK() =>
            (int)Reference.Invoke("getTopK");
        
        
        /// <summary>
        /// Gets uniformDrop value for <see cref="uniformDrop"/>
        /// </summary>
        /// <returns>
        /// uniformDrop: Set this to true to use uniform drop in dart mode
        /// </returns>
        public bool GetUniformDrop() =>
            (bool)Reference.Invoke("getUniformDrop");
        
        
        /// <summary>
        /// Gets useBarrierExecutionMode value for <see cref="useBarrierExecutionMode"/>
        /// </summary>
        /// <returns>
        /// useBarrierExecutionMode: Barrier execution mode which uses a barrier stage, off by default.
        /// </returns>
        public bool GetUseBarrierExecutionMode() =>
            (bool)Reference.Invoke("getUseBarrierExecutionMode");
        
        
        /// <summary>
        /// Gets useSingleDatasetMode value for <see cref="useSingleDatasetMode"/>
        /// </summary>
        /// <returns>
        /// useSingleDatasetMode: Use single dataset execution mode to create a single native dataset per executor (singleton) to reduce memory and communication overhead. Note this is disabled when running spark in local mode.
        /// </returns>
        public bool GetUseSingleDatasetMode() =>
            (bool)Reference.Invoke("getUseSingleDatasetMode");
        
        
        /// <summary>
        /// Gets validationIndicatorCol value for <see cref="validationIndicatorCol"/>
        /// </summary>
        /// <returns>
        /// validationIndicatorCol: Indicates whether the row is for training or validation
        /// </returns>
        public string GetValidationIndicatorCol() =>
            (string)Reference.Invoke("getValidationIndicatorCol");
        
        
        /// <summary>
        /// Gets verbosity value for <see cref="verbosity"/>
        /// </summary>
        /// <returns>
        /// verbosity: Verbosity where lt 0 is Fatal, eq 0 is Error, eq 1 is Info, gt 1 is Debug
        /// </returns>
        public int GetVerbosity() =>
            (int)Reference.Invoke("getVerbosity");
        
        
        /// <summary>
        /// Gets weightCol value for <see cref="weightCol"/>
        /// </summary>
        /// <returns>
        /// weightCol: The name of the weight column
        /// </returns>
        public string GetWeightCol() =>
            (string)Reference.Invoke("getWeightCol");
        
        
        /// <summary>
        /// Gets xgboostDartMode value for <see cref="xgboostDartMode"/>
        /// </summary>
        /// <returns>
        /// xgboostDartMode: Set this to true to use xgboost dart mode
        /// </returns>
        public bool GetXgboostDartMode() =>
            (bool)Reference.Invoke("getXgboostDartMode");

        /// <summary>Fits a model to the input data.</summary>
        /// <param name="dataset">The <see cref="DataFrame"/> to fit the model to.</param>
        /// <returns><see cref="LightGBMRankerModel"/></returns>
        override public LightGBMRankerModel Fit(DataFrame dataset) =>
            new LightGBMRankerModel(
                (JvmObjectReference)Reference.Invoke("fit", dataset));

        /// <summary>
        /// Loads the <see cref="LightGBMRanker"/> that was previously saved using Save(string).
        /// </summary>
        /// <param name="path">The path the previous <see cref="LightGBMRanker"/> was saved to</param>
        /// <returns>New <see cref="LightGBMRanker"/> object, loaded from path.</returns>
        public static LightGBMRanker Load(string path) => WrapAsLightGBMRanker(
            SparkEnvironment.JvmBridge.CallStaticJavaMethod(s_className, "load", path));
        
        /// <summary>
        /// Saves the object so that it can be loaded later using Load. Note that these objects
        /// can be shared with Scala by Loading or Saving in Scala.
        /// </summary>
        /// <param name="path">The path to save the object to</param>
        public void Save(string path) => Reference.Invoke("save", path);
        
        /// <returns>a <see cref="JavaMLWriter"/> instance for this ML instance.</returns>
        public JavaMLWriter Write() =>
            new JavaMLWriter((JvmObjectReference)Reference.Invoke("write"));
        
        /// <returns>an <see cref="JavaMLReader"/> instance for this ML instance.</returns>
        public JavaMLReader<LightGBMRanker> Read() =>
            new JavaMLReader<LightGBMRanker>((JvmObjectReference)Reference.Invoke("read"));

        private static LightGBMRanker WrapAsLightGBMRanker(object obj) =>
            new LightGBMRanker((JvmObjectReference)obj);

        
    }
}

        