using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200060C RID: 1548
	public static class ItemSerializers : Il2CppSystem.Object
	{
		// Token: 0x0600862F RID: 34351 RVA: 0x0023C1C4 File Offset: 0x0023A3C4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSerializers()
		{
			Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSerializers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr);
			ItemSerializers.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, "DEBUG");
			ItemSerializers.NativeMethodInfoPtr_Read_Private_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680169);
			ItemSerializers.NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680170);
			ItemSerializers.NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680171);
			ItemSerializers.NativeMethodInfoPtr_DirectReadItemInstance_Private_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680172);
			ItemSerializers.NativeMethodInfoPtr_WriteStorableItemInstance_Public_Static_Void_Writer_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680173);
			ItemSerializers.NativeMethodInfoPtr_ReadStorableItemInstance_Public_Static_StorableItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680174);
			ItemSerializers.NativeMethodInfoPtr_DirectReadStorableItemInstance_Private_Static_StorableItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680175);
			ItemSerializers.NativeMethodInfoPtr_WriteCashInstance_Public_Static_Void_Writer_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680176);
			ItemSerializers.NativeMethodInfoPtr_ReadCashInstance_Public_Static_CashInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680177);
			ItemSerializers.NativeMethodInfoPtr_DirectReadCashInstance_Private_Static_CashInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680178);
			ItemSerializers.NativeMethodInfoPtr_WriteQualityItemInstance_Public_Static_Void_Writer_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680179);
			ItemSerializers.NativeMethodInfoPtr_ReadQualityItemInstance_Public_Static_QualityItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680180);
			ItemSerializers.NativeMethodInfoPtr_DirectReadQualityItemInstance_Private_Static_QualityItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680181);
			ItemSerializers.NativeMethodInfoPtr_WriteClothingInstance_Public_Static_Void_Writer_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680182);
			ItemSerializers.NativeMethodInfoPtr_ReadClothingInstance_Public_Static_ClothingInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680183);
			ItemSerializers.NativeMethodInfoPtr_DirectReadClothingInstance_Private_Static_ClothingInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680184);
			ItemSerializers.NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680185);
			ItemSerializers.NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680186);
			ItemSerializers.NativeMethodInfoPtr_DirectReadProductItemInstance_Private_Static_ProductItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680187);
			ItemSerializers.NativeMethodInfoPtr_WriteWeedInstance_Public_Static_Void_Writer_WeedInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680188);
			ItemSerializers.NativeMethodInfoPtr_ReadWeedInstance_Public_Static_WeedInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680189);
			ItemSerializers.NativeMethodInfoPtr_DirectReadWeedInstance_Private_Static_WeedInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680190);
			ItemSerializers.NativeMethodInfoPtr_WriteMethInstance_Public_Static_Void_Writer_MethInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680191);
			ItemSerializers.NativeMethodInfoPtr_ReadMethInstance_Public_Static_MethInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680192);
			ItemSerializers.NativeMethodInfoPtr_DirectReadMethInstance_Private_Static_MethInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680193);
			ItemSerializers.NativeMethodInfoPtr_WriteCocaineInstance_Public_Static_Void_Writer_CocaineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680194);
			ItemSerializers.NativeMethodInfoPtr_ReadCocaineInstance_Public_Static_CocaineInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680195);
			ItemSerializers.NativeMethodInfoPtr_DirectReadCocaineInstance_Private_Static_CocaineInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680196);
			ItemSerializers.NativeMethodInfoPtr_WriteIntegerItemInstance_Public_Static_Void_Writer_IntegerItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680197);
			ItemSerializers.NativeMethodInfoPtr_ReadIntegerItemInstance_Public_Static_IntegerItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680198);
			ItemSerializers.NativeMethodInfoPtr_DirectReadIntegerItemInstance_Private_Static_IntegerItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680199);
			ItemSerializers.NativeMethodInfoPtr_WriteWateringCanInstance_Public_Static_Void_Writer_WateringCanInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680200);
			ItemSerializers.NativeMethodInfoPtr_ReadWateringCanInstance_Public_Static_WateringCanInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680201);
			ItemSerializers.NativeMethodInfoPtr_DirectReadWateringCanInstance_Private_Static_WateringCanInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680202);
			ItemSerializers.NativeMethodInfoPtr_WriteTrashGrabberInstance_Public_Static_Void_Writer_TrashGrabberInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680203);
			ItemSerializers.NativeMethodInfoPtr_ReadTrashGrabberInstance_Public_Static_TrashGrabberInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680204);
			ItemSerializers.NativeMethodInfoPtr_DirectReadTrashGrabberInstance_Private_Static_TrashGrabberInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100680205);
		}

		// Token: 0x06008630 RID: 34352 RVA: 0x0023C4EC File Offset: 0x0023A6EC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 251660, RefRangeEnd = 251672, XrefRangeStart = 251572, XrefRangeEnd = 251660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance Read(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_Read_Private_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008631 RID: 34353 RVA: 0x0023C530 File Offset: 0x0023A730
		[CallerCount(94)]
		[CachedScanResults(RefRangeStart = 251694, RefRangeEnd = 251788, XrefRangeStart = 251672, XrefRangeEnd = 251694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteItemInstance(this Writer writer, ItemInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008632 RID: 34354 RVA: 0x0023C578 File Offset: 0x0023A778
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 251789, RefRangeEnd = 251838, XrefRangeStart = 251788, XrefRangeEnd = 251789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance ReadItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008633 RID: 34355 RVA: 0x0023C5BC File Offset: 0x0023A7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251838, XrefRangeEnd = 251842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance DirectReadItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadItemInstance_Private_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008634 RID: 34356 RVA: 0x0023C600 File Offset: 0x0023A800
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 251865, RefRangeEnd = 251871, XrefRangeStart = 251842, XrefRangeEnd = 251865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStorableItemInstance(this Writer writer, StorableItemInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteStorableItemInstance_Public_Static_Void_Writer_StorableItemInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008635 RID: 34357 RVA: 0x0023C648 File Offset: 0x0023A848
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251874, RefRangeEnd = 251877, XrefRangeStart = 251871, XrefRangeEnd = 251874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StorableItemInstance ReadStorableItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadStorableItemInstance_Public_Static_StorableItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008636 RID: 34358 RVA: 0x0023C68C File Offset: 0x0023A88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251877, XrefRangeEnd = 251886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StorableItemInstance DirectReadStorableItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadStorableItemInstance_Private_Static_StorableItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008637 RID: 34359 RVA: 0x0023C6D0 File Offset: 0x0023A8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251886, XrefRangeEnd = 251896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteCashInstance(this Writer writer, CashInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteCashInstance_Public_Static_Void_Writer_CashInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008638 RID: 34360 RVA: 0x0023C718 File Offset: 0x0023A918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251896, XrefRangeEnd = 251899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CashInstance ReadCashInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadCashInstance_Public_Static_CashInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
		}

		// Token: 0x06008639 RID: 34361 RVA: 0x0023C75C File Offset: 0x0023A95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251899, XrefRangeEnd = 251910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CashInstance DirectReadCashInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadCashInstance_Private_Static_CashInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
		}

		// Token: 0x0600863A RID: 34362 RVA: 0x0023C7A0 File Offset: 0x0023A9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251910, XrefRangeEnd = 251915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteQualityItemInstance(this Writer writer, QualityItemInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteQualityItemInstance_Public_Static_Void_Writer_QualityItemInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600863B RID: 34363 RVA: 0x0023C7E8 File Offset: 0x0023A9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251915, XrefRangeEnd = 251918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QualityItemInstance ReadQualityItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadQualityItemInstance_Public_Static_QualityItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600863C RID: 34364 RVA: 0x0023C82C File Offset: 0x0023AA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251918, XrefRangeEnd = 251927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QualityItemInstance DirectReadQualityItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadQualityItemInstance_Private_Static_QualityItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600863D RID: 34365 RVA: 0x0023C870 File Offset: 0x0023AA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251927, XrefRangeEnd = 251937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteClothingInstance(this Writer writer, ClothingInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteClothingInstance_Public_Static_Void_Writer_ClothingInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600863E RID: 34366 RVA: 0x0023C8B8 File Offset: 0x0023AAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251937, XrefRangeEnd = 251940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClothingInstance ReadClothingInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadClothingInstance_Public_Static_ClothingInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingInstance>(intPtr2) : null;
		}

		// Token: 0x0600863F RID: 34367 RVA: 0x0023C8FC File Offset: 0x0023AAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251940, XrefRangeEnd = 251949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClothingInstance DirectReadClothingInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadClothingInstance_Private_Static_ClothingInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingInstance>(intPtr2) : null;
		}

		// Token: 0x06008640 RID: 34368 RVA: 0x0023C940 File Offset: 0x0023AB40
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 251976, RefRangeEnd = 251992, XrefRangeStart = 251949, XrefRangeEnd = 251976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteProductItemInstance(this Writer writer, ProductItemInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x0023C988 File Offset: 0x0023AB88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 251995, RefRangeEnd = 252000, XrefRangeStart = 251992, XrefRangeEnd = 251995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductItemInstance ReadProductItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x0023C9CC File Offset: 0x0023ABCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252000, XrefRangeEnd = 252011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductItemInstance DirectReadProductItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadProductItemInstance_Private_Static_ProductItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
		}

		// Token: 0x06008643 RID: 34371 RVA: 0x0023CA10 File Offset: 0x0023AC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252011, XrefRangeEnd = 252022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWeedInstance(this Writer writer, WeedInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteWeedInstance_Public_Static_Void_Writer_WeedInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008644 RID: 34372 RVA: 0x0023CA58 File Offset: 0x0023AC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252022, XrefRangeEnd = 252025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedInstance ReadWeedInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadWeedInstance_Public_Static_WeedInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedInstance>(intPtr2) : null;
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x0023CA9C File Offset: 0x0023AC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252025, XrefRangeEnd = 252036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedInstance DirectReadWeedInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadWeedInstance_Private_Static_WeedInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedInstance>(intPtr2) : null;
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x0023CAE0 File Offset: 0x0023ACE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252036, XrefRangeEnd = 252047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteMethInstance(this Writer writer, MethInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteMethInstance_Public_Static_Void_Writer_MethInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008647 RID: 34375 RVA: 0x0023CB28 File Offset: 0x0023AD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252047, XrefRangeEnd = 252050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethInstance ReadMethInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadMethInstance_Public_Static_MethInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethInstance>(intPtr2) : null;
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x0023CB6C File Offset: 0x0023AD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252050, XrefRangeEnd = 252061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethInstance DirectReadMethInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadMethInstance_Private_Static_MethInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethInstance>(intPtr2) : null;
		}

		// Token: 0x06008649 RID: 34377 RVA: 0x0023CBB0 File Offset: 0x0023ADB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252061, XrefRangeEnd = 252072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteCocaineInstance(this Writer writer, CocaineInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteCocaineInstance_Public_Static_Void_Writer_CocaineInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600864A RID: 34378 RVA: 0x0023CBF8 File Offset: 0x0023ADF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252072, XrefRangeEnd = 252075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineInstance ReadCocaineInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadCocaineInstance_Public_Static_CocaineInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineInstance>(intPtr2) : null;
		}

		// Token: 0x0600864B RID: 34379 RVA: 0x0023CC3C File Offset: 0x0023AE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252075, XrefRangeEnd = 252086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineInstance DirectReadCocaineInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadCocaineInstance_Private_Static_CocaineInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineInstance>(intPtr2) : null;
		}

		// Token: 0x0600864C RID: 34380 RVA: 0x0023CC80 File Offset: 0x0023AE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252086, XrefRangeEnd = 252096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteIntegerItemInstance(this Writer writer, IntegerItemInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteIntegerItemInstance_Public_Static_Void_Writer_IntegerItemInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600864D RID: 34381 RVA: 0x0023CCC8 File Offset: 0x0023AEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252096, XrefRangeEnd = 252099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntegerItemInstance ReadIntegerItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadIntegerItemInstance_Public_Static_IntegerItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x0023CD0C File Offset: 0x0023AF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252099, XrefRangeEnd = 252108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntegerItemInstance DirectReadIntegerItemInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadIntegerItemInstance_Private_Static_IntegerItemInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600864F RID: 34383 RVA: 0x0023CD50 File Offset: 0x0023AF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252108, XrefRangeEnd = 252118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWateringCanInstance(this Writer writer, WateringCanInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteWateringCanInstance_Public_Static_Void_Writer_WateringCanInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008650 RID: 34384 RVA: 0x0023CD98 File Offset: 0x0023AF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252118, XrefRangeEnd = 252121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WateringCanInstance ReadWateringCanInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadWateringCanInstance_Public_Static_WateringCanInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
		}

		// Token: 0x06008651 RID: 34385 RVA: 0x0023CDDC File Offset: 0x0023AFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252121, XrefRangeEnd = 252131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WateringCanInstance DirectReadWateringCanInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadWateringCanInstance_Private_Static_WateringCanInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
		}

		// Token: 0x06008652 RID: 34386 RVA: 0x0023CE20 File Offset: 0x0023B020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252131, XrefRangeEnd = 252163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTrashGrabberInstance(this Writer writer, TrashGrabberInstance value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteTrashGrabberInstance_Public_Static_Void_Writer_TrashGrabberInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008653 RID: 34387 RVA: 0x0023CE68 File Offset: 0x0023B068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252163, XrefRangeEnd = 252166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrashGrabberInstance ReadTrashGrabberInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadTrashGrabberInstance_Public_Static_TrashGrabberInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
		}

		// Token: 0x06008654 RID: 34388 RVA: 0x0023CEAC File Offset: 0x0023B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252166, XrefRangeEnd = 252188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrashGrabberInstance DirectReadTrashGrabberInstance(this Reader reader)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadTrashGrabberInstance_Private_Static_TrashGrabberInstance_Reader_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
		}

		// Token: 0x06008655 RID: 34389 RVA: 0x0003F758 File Offset: 0x0003D958
		public ItemSerializers(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x06008656 RID: 34390 RVA: 0x0023CEF0 File Offset: 0x0023B0F0
		// (set) Token: 0x06008657 RID: 34391 RVA: 0x0003F761 File Offset: 0x0003D961
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(ItemSerializers.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemSerializers.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x04005B5C RID: 23388
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04005B5D RID: 23389
		private static readonly System.IntPtr NativeMethodInfoPtr_Read_Private_Static_ItemInstance_Reader_0;

		// Token: 0x04005B5E RID: 23390
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0;

		// Token: 0x04005B5F RID: 23391
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0;

		// Token: 0x04005B60 RID: 23392
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadItemInstance_Private_Static_ItemInstance_Reader_0;

		// Token: 0x04005B61 RID: 23393
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteStorableItemInstance_Public_Static_Void_Writer_StorableItemInstance_0;

		// Token: 0x04005B62 RID: 23394
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadStorableItemInstance_Public_Static_StorableItemInstance_Reader_0;

		// Token: 0x04005B63 RID: 23395
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadStorableItemInstance_Private_Static_StorableItemInstance_Reader_0;

		// Token: 0x04005B64 RID: 23396
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteCashInstance_Public_Static_Void_Writer_CashInstance_0;

		// Token: 0x04005B65 RID: 23397
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadCashInstance_Public_Static_CashInstance_Reader_0;

		// Token: 0x04005B66 RID: 23398
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadCashInstance_Private_Static_CashInstance_Reader_0;

		// Token: 0x04005B67 RID: 23399
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteQualityItemInstance_Public_Static_Void_Writer_QualityItemInstance_0;

		// Token: 0x04005B68 RID: 23400
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadQualityItemInstance_Public_Static_QualityItemInstance_Reader_0;

		// Token: 0x04005B69 RID: 23401
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadQualityItemInstance_Private_Static_QualityItemInstance_Reader_0;

		// Token: 0x04005B6A RID: 23402
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteClothingInstance_Public_Static_Void_Writer_ClothingInstance_0;

		// Token: 0x04005B6B RID: 23403
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadClothingInstance_Public_Static_ClothingInstance_Reader_0;

		// Token: 0x04005B6C RID: 23404
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadClothingInstance_Private_Static_ClothingInstance_Reader_0;

		// Token: 0x04005B6D RID: 23405
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0;

		// Token: 0x04005B6E RID: 23406
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0;

		// Token: 0x04005B6F RID: 23407
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadProductItemInstance_Private_Static_ProductItemInstance_Reader_0;

		// Token: 0x04005B70 RID: 23408
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteWeedInstance_Public_Static_Void_Writer_WeedInstance_0;

		// Token: 0x04005B71 RID: 23409
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadWeedInstance_Public_Static_WeedInstance_Reader_0;

		// Token: 0x04005B72 RID: 23410
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadWeedInstance_Private_Static_WeedInstance_Reader_0;

		// Token: 0x04005B73 RID: 23411
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteMethInstance_Public_Static_Void_Writer_MethInstance_0;

		// Token: 0x04005B74 RID: 23412
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadMethInstance_Public_Static_MethInstance_Reader_0;

		// Token: 0x04005B75 RID: 23413
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadMethInstance_Private_Static_MethInstance_Reader_0;

		// Token: 0x04005B76 RID: 23414
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteCocaineInstance_Public_Static_Void_Writer_CocaineInstance_0;

		// Token: 0x04005B77 RID: 23415
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadCocaineInstance_Public_Static_CocaineInstance_Reader_0;

		// Token: 0x04005B78 RID: 23416
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadCocaineInstance_Private_Static_CocaineInstance_Reader_0;

		// Token: 0x04005B79 RID: 23417
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteIntegerItemInstance_Public_Static_Void_Writer_IntegerItemInstance_0;

		// Token: 0x04005B7A RID: 23418
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadIntegerItemInstance_Public_Static_IntegerItemInstance_Reader_0;

		// Token: 0x04005B7B RID: 23419
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadIntegerItemInstance_Private_Static_IntegerItemInstance_Reader_0;

		// Token: 0x04005B7C RID: 23420
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteWateringCanInstance_Public_Static_Void_Writer_WateringCanInstance_0;

		// Token: 0x04005B7D RID: 23421
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadWateringCanInstance_Public_Static_WateringCanInstance_Reader_0;

		// Token: 0x04005B7E RID: 23422
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadWateringCanInstance_Private_Static_WateringCanInstance_Reader_0;

		// Token: 0x04005B7F RID: 23423
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteTrashGrabberInstance_Public_Static_Void_Writer_TrashGrabberInstance_0;

		// Token: 0x04005B80 RID: 23424
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadTrashGrabberInstance_Public_Static_TrashGrabberInstance_Reader_0;

		// Token: 0x04005B81 RID: 23425
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectReadTrashGrabberInstance_Private_Static_TrashGrabberInstance_Reader_0;
	}
}
