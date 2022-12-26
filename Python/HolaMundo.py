import warnings
import numpy as np
import pandas as pd
#import seaborn as sns
import matplotlib.cm as cm
import matplotlib.pyplot as plt 
from sklearn.cluster import KMeans
from sklearn.decomposition import PCA
from sklearn.datasets import make_blobs
from sklearn.preprocessing import MinMaxScaler
from sklearn.preprocessing import StandardScaler
from sklearn.metrics import silhouette_samples, silhouette_score


data=pd.read_csv("C:\\Users\\georg\\source\\Repos\\PythonApplication1\\PredictStudentScore_LinearRegression.csv")
data.head()
data.dtypes