from graphviz import Digraph
from os import chdir

chdir("visualization")

with open("graph.txt", "r") as f:
    graph = f.read().split('\n')
    num, inf = map(int, graph[0].split(' '))
    adjacency = []
    for r in range(num):
        ls = list(map(int, graph[r+1].split(' ')))
        for i, n in enumerate(ls):
            if n == inf:
                ls[i] = 0
        adjacency.append(ls)

arrow = "none"
for i in range(num):
    for j in range(num):
        if adjacency[i][j] != adjacency[j][i]:
            arrow = "normal"
            break
    if arrow == "normal":
        break

dot = Digraph(
    engine="neato", format='png', strict=True,
    graph_attr={"dpi": "300"},
    edge_attr={"len": "5", "fontsize": "24"},
    node_attr={"shape": "circle", "style": "filled",
               "color": "aqua", "fontsize": "24"}
)

for i in range(num):
    dot.node(str(i), label=str(i))

for i in range(num):
    for j in range(i, num):
        if i != j:
            if adjacency[i][j] != 0:
                dot.edge(
                    str(i), str(j),
                    label=str(adjacency[i][j]),
                    arrowhead=arrow
                )
            elif adjacency[j][i] != 0:
                dot.edge(
                    str(j), str(i),
                    label=str(adjacency[j][i]),
                    arrowhead=arrow
                )

dot.render()
