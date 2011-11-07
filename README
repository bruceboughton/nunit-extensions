Examples
========


        [Test]
        public void Equality()
        {
            "a".Should(Be.EqualTo("a"));

            true.Should(Not.Be.EqualTo(false));
        }

        [Test]
        public void Nullity()
        {
            ((object)null).Should(Be.Null);

            new object().Should(Not.Be.Null);
        }

        [Test]
        public void CollectionEquivalence()
        {
            new string[0].Should(Be.EquivalentTo(Enumerable.Empty<string>()));
        }

        [Test]
        public void Members()
        {
            string.Empty.Should(Have.Length.EqualTo(0));

            new List<float> { 5f, 10f, 15f }.Should(Have.Count.EqualTo(3));

            DateTime.Today.Should(Have.Property("DayOfWeek"));
        }

        [Test]
        public void Exceptions()
        {
            The.Invocation(() => { throw new ArgumentException("test"); }).Should(Throw.ArgumentException.With.Property("Message").EqualTo("test"));
            The.Invocation(() => ((object)null).ToString()).Should(Throw.InstanceOf<NullReferenceException>());

            The.Invocation(() => "hello".Reverse()).Should(Not.Throw);
	}