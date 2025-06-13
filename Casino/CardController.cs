using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004C3 RID: 1219
	public class CardController : NetworkBehaviour
	{
		// Token: 0x060068F2 RID: 26866 RVA: 0x001D981C File Offset: 0x001D7A1C
		// Note: this type is marked as 'beforefieldinit'.
		static CardController()
		{
			Il2CppClassPointerStore<CardController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CardController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardController>.NativeClassPtr);
			CardController.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "cards");
			CardController.NativeFieldInfoPtr_cardDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "cardDictionary");
			CardController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted");
			CardController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted");
			CardController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676685);
			CardController.NativeMethodInfoPtr_SendCardValue_Public_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676686);
			CardController.NativeMethodInfoPtr_SetCardValue_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676687);
			CardController.NativeMethodInfoPtr_SendCardFaceUp_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676688);
			CardController.NativeMethodInfoPtr_SetCardFaceUp_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676689);
			CardController.NativeMethodInfoPtr_SendCardGlide_Public_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676690);
			CardController.NativeMethodInfoPtr_SetCardGlide_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676691);
			CardController.NativeMethodInfoPtr_GetCard_Private_PlayingCard_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676692);
			CardController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676693);
			CardController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676694);
			CardController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676695);
			CardController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676696);
			CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676697);
			CardController.NativeMethodInfoPtr_RpcLogic___SendCardValue_3709737967_Public_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676698);
			CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardValue_3709737967_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676699);
			CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676700);
			CardController.NativeMethodInfoPtr_RpcLogic___SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676701);
			CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardValue_3709737967_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676702);
			CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardFaceUp_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676703);
			CardController.NativeMethodInfoPtr_RpcLogic___SendCardFaceUp_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676704);
			CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardFaceUp_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676705);
			CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardFaceUp_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676706);
			CardController.NativeMethodInfoPtr_RpcLogic___SetCardFaceUp_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676707);
			CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardFaceUp_310431262_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676708);
			CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676709);
			CardController.NativeMethodInfoPtr_RpcLogic___SendCardGlide_2833372058_Public_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676710);
			CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardGlide_2833372058_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676711);
			CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676712);
			CardController.NativeMethodInfoPtr_RpcLogic___SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676713);
			CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardGlide_2833372058_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676714);
			CardController.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676715);
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x001D9B08 File Offset: 0x001D7D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212828, XrefRangeEnd = 212829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x001D9B44 File Offset: 0x001D7D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212853, RefRangeEnd = 212854, XrefRangeStart = 212829, XrefRangeEnd = 212853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SendCardValue_Public_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x001D9BA4 File Offset: 0x001D7DA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212878, RefRangeEnd = 212880, XrefRangeStart = 212854, XrefRangeEnd = 212878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SetCardValue_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x001D9C04 File Offset: 0x001D7E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212903, RefRangeEnd = 212905, XrefRangeStart = 212880, XrefRangeEnd = 212903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCardFaceUp(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SendCardFaceUp_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068F7 RID: 26871 RVA: 0x001D9C54 File Offset: 0x001D7E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212928, RefRangeEnd = 212930, XrefRangeStart = 212905, XrefRangeEnd = 212928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardFaceUp(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SetCardFaceUp_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068F8 RID: 26872 RVA: 0x001D9CA4 File Offset: 0x001D7EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212933, RefRangeEnd = 212934, XrefRangeStart = 212930, XrefRangeEnd = 212933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SendCardGlide_Public_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068F9 RID: 26873 RVA: 0x001D9D10 File Offset: 0x001D7F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212934, XrefRangeEnd = 212936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SetCardGlide_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068FA RID: 26874 RVA: 0x001D9D7C File Offset: 0x001D7F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212936, XrefRangeEnd = 212940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard GetCard(string cardId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_GetCard_Private_PlayingCard_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x001D9DCC File Offset: 0x001D7FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212940, XrefRangeEnd = 212955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CardController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x001D9E08 File Offset: 0x001D8008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212955, XrefRangeEnd = 212993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x001D9E44 File Offset: 0x001D8044
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x001D9E80 File Offset: 0x001D8080
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x001D9EBC File Offset: 0x001D80BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212993, XrefRangeEnd = 213005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x001D9F1C File Offset: 0x001D811C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212878, RefRangeEnd = 212880, XrefRangeStart = 212878, XrefRangeEnd = 212880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SendCardValue_3709737967_Public_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x001D9F7C File Offset: 0x001D817C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213005, XrefRangeEnd = 213011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCardValue_3709737967(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardValue_3709737967_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x001D9FE0 File Offset: 0x001D81E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213011, XrefRangeEnd = 213023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x001DA040 File Offset: 0x001D8240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213031, RefRangeEnd = 213034, XrefRangeStart = 213023, XrefRangeEnd = 213031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006904 RID: 26884 RVA: 0x001DA0A0 File Offset: 0x001D82A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213034, XrefRangeEnd = 213040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCardValue_3709737967(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardValue_3709737967_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x001DA0F0 File Offset: 0x001D82F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213040, XrefRangeEnd = 213051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardFaceUp_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x001DA140 File Offset: 0x001D8340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212928, RefRangeEnd = 212930, XrefRangeStart = 212928, XrefRangeEnd = 212930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SendCardFaceUp_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x001DA190 File Offset: 0x001D8390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213051, XrefRangeEnd = 213055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCardFaceUp_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardFaceUp_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x001DA1F4 File Offset: 0x001D83F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213055, XrefRangeEnd = 213066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardFaceUp_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x001DA244 File Offset: 0x001D8444
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213074, RefRangeEnd = 213077, XrefRangeStart = 213066, XrefRangeEnd = 213074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SetCardFaceUp_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x001DA294 File Offset: 0x001D8494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213077, XrefRangeEnd = 213081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCardFaceUp_310431262(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardFaceUp_310431262_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x001DA2E4 File Offset: 0x001D84E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213107, RefRangeEnd = 213108, XrefRangeStart = 213081, XrefRangeEnd = 213107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x001DA350 File Offset: 0x001D8550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SendCardGlide_2833372058_Public_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x001DA3BC File Offset: 0x001D85BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213108, XrefRangeEnd = 213119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCardGlide_2833372058(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardGlide_2833372058_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x001DA420 File Offset: 0x001D8620
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 213145, RefRangeEnd = 213149, XrefRangeStart = 213119, XrefRangeEnd = 213145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x001DA48C File Offset: 0x001D868C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213157, RefRangeEnd = 213162, XrefRangeStart = 213149, XrefRangeEnd = 213157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x001DA4F8 File Offset: 0x001D86F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213162, XrefRangeEnd = 213172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCardGlide_2833372058(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardGlide_2833372058_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x001DA548 File Offset: 0x001D8748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213213, RefRangeEnd = 213214, XrefRangeStart = 213172, XrefRangeEnd = 213213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x00031632 File Offset: 0x0002F832
		public CardController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x06006913 RID: 26899 RVA: 0x001DA57C File Offset: 0x001D877C
		// (set) Token: 0x06006914 RID: 26900 RVA: 0x0003163B File Offset: 0x0002F83B
		public unsafe List<PlayingCard> cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06006915 RID: 26901 RVA: 0x001DA5AC File Offset: 0x001D87AC
		// (set) Token: 0x06006916 RID: 26902 RVA: 0x0003165A File Offset: 0x0002F85A
		public unsafe Dictionary<string, PlayingCard> cardDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06006917 RID: 26903 RVA: 0x001DA5DC File Offset: 0x001D87DC
		// (set) Token: 0x06006918 RID: 26904 RVA: 0x00031679 File Offset: 0x0002F879
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06006919 RID: 26905 RVA: 0x001DA604 File Offset: 0x001D8804
		// (set) Token: 0x0600691A RID: 26906 RVA: 0x00031694 File Offset: 0x0002F894
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040047D2 RID: 18386
		private static readonly IntPtr NativeFieldInfoPtr_cards;

		// Token: 0x040047D3 RID: 18387
		private static readonly IntPtr NativeFieldInfoPtr_cardDictionary;

		// Token: 0x040047D4 RID: 18388
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040047D5 RID: 18389
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040047D6 RID: 18390
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040047D7 RID: 18391
		private static readonly IntPtr NativeMethodInfoPtr_SendCardValue_Public_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x040047D8 RID: 18392
		private static readonly IntPtr NativeMethodInfoPtr_SetCardValue_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x040047D9 RID: 18393
		private static readonly IntPtr NativeMethodInfoPtr_SendCardFaceUp_Public_Void_String_Boolean_0;

		// Token: 0x040047DA RID: 18394
		private static readonly IntPtr NativeMethodInfoPtr_SetCardFaceUp_Private_Void_String_Boolean_0;

		// Token: 0x040047DB RID: 18395
		private static readonly IntPtr NativeMethodInfoPtr_SendCardGlide_Public_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x040047DC RID: 18396
		private static readonly IntPtr NativeMethodInfoPtr_SetCardGlide_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x040047DD RID: 18397
		private static readonly IntPtr NativeMethodInfoPtr_GetCard_Private_PlayingCard_String_0;

		// Token: 0x040047DE RID: 18398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040047DF RID: 18399
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040047E0 RID: 18400
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040047E1 RID: 18401
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040047E2 RID: 18402
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x040047E3 RID: 18403
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCardValue_3709737967_Public_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x040047E4 RID: 18404
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCardValue_3709737967_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040047E5 RID: 18405
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x040047E6 RID: 18406
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x040047E7 RID: 18407
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCardValue_3709737967_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047E8 RID: 18408
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCardFaceUp_310431262_Private_Void_String_Boolean_0;

		// Token: 0x040047E9 RID: 18409
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCardFaceUp_310431262_Public_Void_String_Boolean_0;

		// Token: 0x040047EA RID: 18410
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCardFaceUp_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040047EB RID: 18411
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCardFaceUp_310431262_Private_Void_String_Boolean_0;

		// Token: 0x040047EC RID: 18412
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCardFaceUp_310431262_Private_Void_String_Boolean_0;

		// Token: 0x040047ED RID: 18413
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCardFaceUp_310431262_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047EE RID: 18414
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x040047EF RID: 18415
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCardGlide_2833372058_Public_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x040047F0 RID: 18416
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCardGlide_2833372058_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040047F1 RID: 18417
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x040047F2 RID: 18418
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x040047F3 RID: 18419
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCardGlide_2833372058_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047F4 RID: 18420
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
