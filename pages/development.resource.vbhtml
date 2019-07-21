<link type="text/css" rel="stylesheet" href="styles/vscode.css" />

<script type="text/javascript" src="lib/linq.min.js"></script>
<script type="text/javascript" src="lib/vbcode.min.js"></script>
<script type="text/javascript" src="lib/marked.min.js"></script>

<div class="row">
	<div class="small-12 columns">

		<h1>The genomics CAD(Computer Assistant Design) Modeller System and Artificial Life</h1>

		<p>
			While there is a clear overlap between the research field of artificial life (AL) and artificial
			intelligence (AI), but they have very different Intentions and Evolutionary histories actually. The research
			of Artificial intelligence is about how to achieve analog intelligence has been rise since the early days of
			computer Technology history. But the artificial life research about trying to clarify the nature of
			artificial life, the emergent behaviors, it can be said, that no one else is doing similar work and alone
			until the late 1980s, the AL research field was officially born, and began growing from year 2010.
		</p>

		<p>
			Theoretically, as long as we can design a network model that it is complex enough to contains a relatively
			complete feedback loops, and then we run the simulation of this network model, the emergent behaviors will
			Appear in this complex network model. Which means we have succeeded bring an artificial life system born in
			our world. The GCModeller project was created to help people design this complex network of artificial life
			systems more easily.
		</p>

		<p>
			In the exploration of how to carry out the design of artificial life system, we currently have two
			directions of work to finish an artificial life system transformation design: forward engineering and
			reverse engineering.
		</p>

		<p>
			In the field of synthetic biology, a full-length DNA sequence of a genome is the target product of our
			artificial life system design work, and the desired biological phenotype are encoded as DNA sequences stored
			in the designed genome, thus compiling into an artificial life system application. For the synthetic design
			analysis of the DNA sequence in artificial life system, we could:
		</p>

		<p>
			1. Forward engineering refers to Fill the cellular model container with protein components needed to produce
			the required biological phenotype through the CAD AL design software platform, based on the objectives we
			expected. And then run the simulation of this filled cellular model. After we have achieved our
			expectations, then these protein components reverse-generated to their corresponding genome sequences
			including their expression regulatory components to finish the generation of a complete whole genome DNA
			sequence.
		</p>

		<p>

			<div align=center>
				<iframe src="//player.bilibili.com/player.html?aid=58675156&cid=102313656&page=1" scrolling="no"
					border="0" frameborder="no" framespacing="0" allowfullscreen="true" width="720" height="480">
				</iframe>
			</div>

			2. Reverse engineering is a very common method we currently use to study and analyze the target genome.
			Through reverse engineering, we perform functional annotation of protein components in the target genome,
			and then build a blueprint (which is so called pathway) for biological functions based on these annotated
			protein components. Based on this blueprint, High throughput omics technology like genomics, proteomics and
			metabonomics analysis of mutants is performed to understand the causes of change and the impact of change.
		</p>

		<p>
			In the analysis of artificial life system design in these two direction that mentioned above, GCModeller
			attempts to provide a relative complete CAD tool chain of following:
		</p>

		<p>
			<ul>
				<li>1. Annotation protocols for the cell components</li>
				<li>2. Assemble a complete cell data model based on the results of the cell component annotation results
				</li>
				<li>3. Provide an environment for simulated calculations of the annotated cell model</li>
				<li>4. Provide a storage program for storing data for the entire simulation process</li>
				<li>5. Providing an analysis tools allows users to determine whether their design is effective by
					analyzing the saved simulation data.</li>
				<li>6. Export the cell model from the target design into a complete chromosomal full-length DNA sequence
					for synthetic or wild mutation experimental design</li>

			</ul>
		</p>

	</div>
</div>

<script type="text/javascript">vscode.highlightVB();</script>
<script type="text/javascript" src="/lib/resize.js"></script>