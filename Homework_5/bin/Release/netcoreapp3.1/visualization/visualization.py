from graphviz import Digraph
from os import chdir

chdir("visualization")

dot = Digraph(
    engine="neato", format='png', strict=True,
    graph_attr={"dpi": "300"},
    edge_attr={"len": "5", "fontsize": "24"},
    node_attr={"shape": "circle", "style": "filled",
               "color": "aqua", "fontsize": "24"}
)

with open("graph.txt", "r") as f:
    text = f.read().split('\n')
    vertexNum, edgeNum = map(int, text[0:2])
    for i in range(vertexNum):
        dot.node(str(i), label=str(i))
    for i in range(edgeNum):
        a, b, weight = text[i+2].split(' ')
        dot.edge(
            a, b,
            label=weight,
            arrowhead="none"
        )
    for i in range(int(text[edgeNum+2])):
        a, b, weight = text[i+3+edgeNum].split(' ')
        dot.edge(
            a, b,
            label=weight,
            arrowhead="none",
            color="red"
        )

dot.render()
