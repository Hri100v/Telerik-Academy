# Creational Design Patterns

## Singleton
Това е Design Pattern, който нарушава някой от ООП принципи (и SOLID _single responsibility_). Затова този патърн носи със себе си 'тежести', проблеми за отстраняване.

* **Мотивация:**
	- Използва се за неща, които са глобални и единствени за приложението

* **Цел:**
	- Подсигурява се създаването от класа на единствена инстанция и също глобален достъп до нея

* **Приложение:**
	- Highscore (в игрите)
	- file system

* **Известни употреби:**
	- window manager, file system, logger

* **Имплементация** (реално изпълнение)
	* Singleton - First version
	~~~c#
	public sealed class Singleton
	{
	    private static Singleton instance = null;

	    private Singleton()
	    {
	    }

	    public static Singleton Instance
	    {
	        get
	        {
	            if (instance==null)
	            {
	                instance = new Singleton();
	            }
	            return instance;
	        }
	    }
	}
	~~~

	* Singleton - Second version _simple thread-safety_
	Becouse two different threads could both have evaluated the test if (instance == null) and found it to be true.
	~~~c#
	public sealed class Singleton
	{
	    private static Singleton instance = null;
	    private static readonly object padlock = new object();

	    Singleton()
	    {
	    }

	    public static Singleton Instance
	    {
	        get
	        {
	            lock (padlock)
	            {
	                if (instance == null)
	                {
	                    instance = new Singleton();
	                }
	                return instance;
	            }
	        }
	    }
	}
	~~~

* **Участници**
	- В общия случай не се разрешени настройки на параметрите

* **Последствия**
	* базовата имплементация (non thread-safe)
		не може да се използва в многонишкова среда

	* tight coupling
		зависим от този клас (_Singleton_)

* **Проблеми**
	- Да не се създава предварително, а в първият момент когато бъде извикана инстанцията
	- Използването на няколко нишки
	- Много силен каплинг

---------------
## Builder

* **Мотивация:**
	Създава обекти, за които има на друго място изградена логика за последователността на вграждане на елементи. 'Builder' се използва, като интерфейс и по този начин се спестява допълнителната информация от съставните елементи.

* **Цел:**
	- Разделяне на сложен обект на неговите съставни (представителни) елементи, така че същият конструктор да може да създаде обект и от други съставни елементи

	- Чрез използването на сложни съставни елементи, трябва да може да се създаде една от няколко цели

* **Приложение:**
	- Постъпково изпълнение на нещо

* **Известни употреби:**
	- конструирането на HTML докимент

* **Имплементация** (реално изпълнение)
	~~~c#
	using System;
	using System.Collections;

	  public class MainApp
	  {
	    public static void Main()
	    { 
	      // Create director and builders 
	      Director director = new Director();

	      Builder b1 = new ConcreteBuilder1();
	      Builder b2 = new ConcreteBuilder2();

	      // Construct two products 
	      director.Construct(b1);
	      Product p1 = b1.GetResult();
	      p1.Show();

	      director.Construct(b2);
	      Product p2 = b2.GetResult();
	      p2.Show();

	      // Wait for user 
	      Console.Read();
	    }
	  }

	  // "Director" 
	  class Director
	  {
	    // Builder uses a complex series of steps 
	    public void Construct(Builder builder)
	    {
	      builder.BuildPartA();
	      builder.BuildPartB();
	    }
	  }

	  // "Builder" 
	  abstract class Builder
	  {
	    public abstract void BuildPartA();
	    public abstract void BuildPartB();
	    public abstract Product GetResult();
	  }

	  // "ConcreteBuilder1" 
	  class ConcreteBuilder1 : Builder
	  {
	    private Product product = new Product();

	    public override void BuildPartA()
	    {
	      product.Add("PartA");
	    }

	    public override void BuildPartB()
	    {
	      product.Add("PartB");
	    }

	    public override Product GetResult()
	    {
	      return product;
	    }
	  }

	  // "ConcreteBuilder2" 
	  class ConcreteBuilder2 : Builder
	  {
	    private Product product = new Product();

	    public override void BuildPartA()
	    {
	      product.Add("PartX");
	    }

	    public override void BuildPartB()
	    {
	      product.Add("PartY");
	    }

	    public override Product GetResult()
	    {
	      return product;
	    }
	  }

	  // "Product" 
	  class Product
	  {
	    ArrayList parts = new ArrayList();

	    public void Add(string part)
	    {
	      parts.Add(part);
	    }

	    public void Show()
	    {
	      Console.WriteLine("\nProduct Parts -------");
	      foreach (string part in parts)
	        Console.WriteLine(part);
	    }
	  }
	~~~
* **Участници**

* **Последствия**
	* скрива функционалност, когато има много неща за изграждането на един обект
	* конструиране на елементите в определен ред

* **Структура**
	UML diagram of Builder pattern
	![images][img]
	[img]: https://github.com/Hri100v/Telerik-Academy/blob/master/Programming/H8%20-%20HighQualityCode/17%20-%20Design%20Patterns%20%5E%20Creational/images/Builder_UML_class_diagram.svg.png "Builder UML diagram"

* **Сродни модели** (related patterns)
	+ Simple Factory
	+ Factory Method
	+ Abstract Factory

* **Проблеми**
	- Създаване на един сложен обект. Спецификацията на този обект се съхранва във вторичен клас. Така за изграждането на един определен обект трябва да се използва един от многото варианти на конструиране и да се създаде инстанция в първичното изграждане ('дирктора')

---------------
## Object Pool

* **Мотивация:**

* **Цел:**

* **Приложение:**

* **Известни употреби:**

* **Имплементация** (реално изпълнение)

* **Участници**

* **Последствия**

* **Структура**

* **Сродни модели** (related patterns)
