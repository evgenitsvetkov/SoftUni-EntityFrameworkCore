SELECT v.[Name], COUNT(*) AS TotalMinions
FROM Villains AS v
JOIN MinionsVillains AS mv ON mv.VillainId = v.Id
GROUP BY v.[Name]
HAVING COUNT(*) > 3
ORDER BY TotalMinions DESC