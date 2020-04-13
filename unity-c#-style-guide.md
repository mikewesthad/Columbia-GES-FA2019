# GES Style Guide

A style guide for Unity projects, mixing elements from [raywenderlich/c-sharp-style-guide](https://github.com/raywenderlich/c-sharp-style-guide) and David Antognoli's [Code and Unity style conventions](https://docs.google.com/document/d/1yrKCY_sVAdWkwgWAjJLiJFj1OOHn6dC__pGkSVB61YY/edit).

## Table of Contents

- [Golden Rules](#golden-rules)
- [Naming](#naming)
- [Brace Style](#brace-style)
- [Access Level Modifiers](#access-level-modifiers)

## Golden Rules

- Favor clarity in your code. Code is meant to be read - by teammates or by yourself in the future - so aim to make your code readable.
- Use consistent style conventions when writing your code. When you write your code in a consistent style, it is easier to read.

## Naming

In gereral, naming should follow C# standards. See Microsoft's [naming conventions guide](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions) and [capitalization guide](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions). A few concessions are made to match the Unity style used in their tutorials.

### Descriptive Naming

- Favor clarity and readability over brevity. `CanScrollHorizontally` is more understandable than `ScrollableX`, and both are better than a random variable named `s`!
- Classes/variables/fields/properties should generally be nouns, `explosiveForce` instead of `explode`.
- Methods/functions should generally be verbs, `ApplyHorizontalForce` instead of `HorizontalForce`.
- Bool variables should generally be framed as a question, `isInvulernable` or `hasKey`.

### Casing

| Identifier | Casing | Example |
|---|---|---|
| Class | PascalCase | `RadialSlider` |
| Methods | PascalCase | `TakeItem()` |
| Fields | camelCase | `craftingInventory` |
| Properties | PascalCase | `CurrentMusicTrack` |
| Parameters | camelCase | `playerLocation` |
| Local Variables | camelCase | `explosiveForce` |

Here is an example that incorperates all of these:

```cs
// PascalCase for Class:
public class BallThrow : MonoBehaviour
{
    // camelCase for fields:
    [SerializeField] GameObject ballPrefab;
    [SerializeField] float shootForce = 10f;
    
    // PascalCase for properties:
    public bool CanShoot { get; private set; }
    
    void Update()
    {
        // camelCase for local variables:
        bool isMouseDown = Input.GetMouseButtonDown(0);
        
        if (CanShoot && isMouseDown)
        {
            ThrowBall(transform.position, transform.forward * shootForce);
            CanShoot = false;
            Invoke("EnableShooting", 1 / shotsPerSecond);
        }
    }
    
    // PascalCase for methods and camelCase for parameters:
    void ThrowBall(Vector3 startingPosition, Vector3 throwForce)
    {
        GameObject ball = Instantiate(ballPrefab, startingPosition, Quaternion.identity);
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        ballRigidbody.AddForce(throwForce, ForceMode.Impulse);
    }

    void EnableShooting()
    {
        canShoot = true;
    }
}
```

## Brace Style

All braces get their own line as it is a C# convention:

**AVOID:**

```csharp
class MyClass {
    void DoSomething() {
        if (someTest) {
          // ...
        } else {
          // ...
        }
    }
}
```

**PREFER:**

```csharp
class MyClass
{
    void DoSomething()
    {
        if (someTest)
        {
          // ...
        }
        else
        {
          // ...
        }
    }
}
```

## Access Level Modifiers

- Default to making everything `private`. Only use a more permissive access level (like `public`) when it is necessary.
- Use `[SerializeField]` for exposing parameters in the Unity inspector, not the public access modifers.
