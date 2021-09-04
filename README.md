# Geometry

SELECT P.Name, C.Name FROM Products as P FULL OUTER JOIN ProductsCategories AS PC ON P.ID = PC.ProductID FULL OUTER JOIN Categories AS C ON PC.CategoryID = C.ID
