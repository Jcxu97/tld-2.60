using Cpp2ILInjected;
using UnityEngine;

namespace InteractiveObjects;

[Token(Token = "0x200131E")]
public interface ITrackable
{
	[Token(Token = "0x6007A8F")]
	bool CanTrack();

	[Token(Token = "0x6007A90")]
	bool IsUnlocked();

	[Token(Token = "0x6007A91")]
	Transform GetTransform();

	[Token(Token = "0x6007A92")]
	TrackableItemType GetItemType();

	[Token(Token = "0x6007A93")]
	TrackableItemData GetItemData();

	[Token(Token = "0x6007A94")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	float GetEstimatedDistance()
	{
		return 0f;
	}
}
