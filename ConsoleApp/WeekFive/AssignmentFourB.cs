namespace Practise.WeekFive
{
    class AnimalBreathe<T> where T : Animal.Animal
    {
        private T _animal;

        public AnimalBreathe(T animal)
        {
            _animal = animal;
        }

        public void HelpAnimalBreathe()
        {
            _animal.Breathe("oxygen");
        }
    }
}
