

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Pawn.h"
#include "AnimalPawn.generated.h"

UCLASS()
class GAD213_PROJECT2_API AAnimalPawn : public APawn
{
	GENERATED_BODY()

public:
	// Sets default values for this pawn's properties
	AAnimalPawn();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

	// Called to bind functionality to input
	virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;

};
