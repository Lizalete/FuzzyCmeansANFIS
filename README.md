# FuzzyCmeansANFIS
FuzzyCmeansANFIS in C#

MACKEY GLASS
FILL method:
Receives the four parameters of the Mackey Glass equation (β, γ, τ and n) and the number of points to plot (10,000)
The method gives the first 18 points, with these and the MG, it creates the rest of the points
Removes the first 100 points of the list
Converts the points into 3D points in order to plot them

CLUSTERS AND FUZZIFICATION
Classification with 100 random clusters
Use of K means for the cluster selection
Use of fuzzy C-Means equation
According to its percentage of membership of the 100 clusters, is the color the point will have

BACKPROPAGATION
The data, the clusters and the percentage of membership are stored in order to give this information to the Backpropagation
Entrance: Percentage of membership
Use of one layer with five neurons and a .95 learning rate
Output: A 3D point (x,y and z)
In a simple interface, we load the data, we make the training while we show the error rate and finally we store the results
At the end, we plot the results
