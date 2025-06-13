using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x02000172 RID: 370
	public class Registry : PersistentSingleton<Registry>
	{
		// Token: 0x06001D6F RID: 7535 RVA: 0x000CEC80 File Offset: 0x000CCE80
		// Note: this type is marked as 'beforefieldinit'.
		static Registry()
		{
			Il2CppClassPointerStore<Registry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "Registry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry>.NativeClassPtr);
			Registry.NativeFieldInfoPtr_ObjectRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ObjectRegistry");
			Registry.NativeFieldInfoPtr_ItemRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemRegistry");
			Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemsAddedAtRuntime");
			Registry.NativeFieldInfoPtr_ItemDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemDictionary");
			Registry.NativeFieldInfoPtr_itemIDAliases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "itemIDAliases");
			Registry.NativeFieldInfoPtr_Seeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry>.NativeClassPtr, "Seeds");
			Registry.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666650);
			Registry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666651);
			Registry.NativeMethodInfoPtr_GetPrefab_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666652);
			Registry.NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666653);
			Registry.NativeMethodInfoPtr_ItemExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666654);
			Registry.NativeMethodInfoPtr_GetItem_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666655);
			Registry.NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666656);
			Registry.NativeMethodInfoPtr_GetConstructable_Public_Static_Constructable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666657);
			Registry.NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666658);
			Registry.NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666659);
			Registry.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666660);
			Registry.NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666661);
			Registry.NativeMethodInfoPtr_GetAllItems_Public_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666662);
			Registry.NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666663);
			Registry.NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666664);
			Registry.NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666665);
			Registry.NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666666);
			Registry.NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666667);
			Registry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry>.NativeClassPtr, 100666668);
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x000CEEA4 File Offset: 0x000CD0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107640, XrefRangeEnd = 107688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x000CEED8 File Offset: 0x000CD0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107688, XrefRangeEnd = 107732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Registry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x000CEF14 File Offset: 0x000CD114
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107751, RefRangeEnd = 107754, XrefRangeStart = 107732, XrefRangeEnd = 107751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject GetPrefab(string id)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetPrefab_Public_Static_GameObject_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000CEF58 File Offset: 0x000CD158
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 107760, RefRangeEnd = 107829, XrefRangeStart = 107754, XrefRangeEnd = 107760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemDefinition GetItem(string ID)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x000CEF9C File Offset: 0x000CD19C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107839, RefRangeEnd = 107840, XrefRangeStart = 107829, XrefRangeEnd = 107839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ItemExists(string ID)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_ItemExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x000CEFE0 File Offset: 0x000CD1E0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 107849, RefRangeEnd = 107863, XrefRangeStart = 107840, XrefRangeEnd = 107849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetItem<T>(string ID) where T : ItemDefinition
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Registry.MethodInfoStoreGeneric_GetItem_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x000CF020 File Offset: 0x000CD220
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 107907, RefRangeEnd = 107912, XrefRangeStart = 107863, XrefRangeEnd = 107907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinition _GetItem(string ID, bool warnIfNonExistent = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref warnIfNonExistent;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x000CF080 File Offset: 0x000CD280
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 107939, RefRangeEnd = 107945, XrefRangeStart = 107912, XrefRangeEnd = 107939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Constructable GetConstructable(string id)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetConstructable_Public_Static_Constructable_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x000CF0C4 File Offset: 0x000CD2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107945, XrefRangeEnd = 107947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHash(string ID)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x000CF108 File Offset: 0x000CD308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107947, XrefRangeEnd = 107956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveAssetsAndPrefab(string originalString)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(originalString);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x000CF144 File Offset: 0x000CD344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107956, XrefRangeEnd = 107971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Registry.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x000CF180 File Offset: 0x000CD380
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107999, RefRangeEnd = 108002, XrefRangeStart = 107971, XrefRangeEnd = 107999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToRegistry(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000CF1C4 File Offset: 0x000CD3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108021, RefRangeEnd = 108022, XrefRangeStart = 108002, XrefRangeEnd = 108021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemDefinition> GetAllItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_GetAllItems_Public_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x000CF204 File Offset: 0x000CD404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108040, RefRangeEnd = 108042, XrefRangeStart = 108022, XrefRangeEnd = 108040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToItemDictionary(Registry.ItemRegister reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000CF248 File Offset: 0x000CD448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108042, XrefRangeEnd = 108047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItemFromDictionary(Registry.ItemRegister reg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reg);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x000CF28C File Offset: 0x000CD48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108047, XrefRangeEnd = 108099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRuntimeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x000CF2C0 File Offset: 0x000CD4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108099, XrefRangeEnd = 108120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromRegistry(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x000CF304 File Offset: 0x000CD504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108120, XrefRangeEnd = 108190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOrderedUnlocks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000CF338 File Offset: 0x000CD538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108190, XrefRangeEnd = 108241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Registry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00010A5A File Offset: 0x0000EC5A
		public Registry(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x000CF374 File Offset: 0x000CD574
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x00010A63 File Offset: 0x0000EC63
		public unsafe List<Registry.ObjectRegister> ObjectRegistry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ObjectRegistry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ObjectRegister>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ObjectRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x000CF3A4 File Offset: 0x000CD5A4
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x00010A82 File Offset: 0x0000EC82
		public unsafe List<Registry.ItemRegister> ItemRegistry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemRegistry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x000CF3D4 File Offset: 0x000CD5D4
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x00010AA1 File Offset: 0x0000ECA1
		public unsafe List<Registry.ItemRegister> ItemsAddedAtRuntime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemsAddedAtRuntime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x000CF404 File Offset: 0x000CD604
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		public unsafe Dictionary<int, Registry.ItemRegister> ItemDictionary
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemDictionary);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Registry.ItemRegister>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_ItemDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x000CF434 File Offset: 0x000CD634
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x00010ADF File Offset: 0x0000ECDF
		public unsafe Dictionary<string, string> itemIDAliases
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_itemIDAliases);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_itemIDAliases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x000CF464 File Offset: 0x000CD664
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x00010AFE File Offset: 0x0000ECFE
		public unsafe List<SeedDefinition> Seeds
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_Seeds);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SeedDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.NativeFieldInfoPtr_Seeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400137E RID: 4990
		private static readonly System.IntPtr NativeFieldInfoPtr_ObjectRegistry;

		// Token: 0x0400137F RID: 4991
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemRegistry;

		// Token: 0x04001380 RID: 4992
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemsAddedAtRuntime;

		// Token: 0x04001381 RID: 4993
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemDictionary;

		// Token: 0x04001382 RID: 4994
		private static readonly System.IntPtr NativeFieldInfoPtr_itemIDAliases;

		// Token: 0x04001383 RID: 4995
		private static readonly System.IntPtr NativeFieldInfoPtr_Seeds;

		// Token: 0x04001384 RID: 4996
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04001385 RID: 4997
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001386 RID: 4998
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefab_Public_Static_GameObject_String_0;

		// Token: 0x04001387 RID: 4999
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Static_ItemDefinition_String_0;

		// Token: 0x04001388 RID: 5000
		private static readonly System.IntPtr NativeMethodInfoPtr_ItemExists_Public_Static_Boolean_String_0;

		// Token: 0x04001389 RID: 5001
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Static_T_String_0;

		// Token: 0x0400138A RID: 5002
		private static readonly System.IntPtr NativeMethodInfoPtr__GetItem_Public_ItemDefinition_String_Boolean_0;

		// Token: 0x0400138B RID: 5003
		private static readonly System.IntPtr NativeMethodInfoPtr_GetConstructable_Public_Static_Constructable_String_0;

		// Token: 0x0400138C RID: 5004
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHash_Private_Static_Int32_String_0;

		// Token: 0x0400138D RID: 5005
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAssetsAndPrefab_Private_Static_String_String_0;

		// Token: 0x0400138E RID: 5006
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400138F RID: 5007
		private static readonly System.IntPtr NativeMethodInfoPtr_AddToRegistry_Public_Void_ItemDefinition_0;

		// Token: 0x04001390 RID: 5008
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAllItems_Public_List_1_ItemDefinition_0;

		// Token: 0x04001391 RID: 5009
		private static readonly System.IntPtr NativeMethodInfoPtr_AddToItemDictionary_Private_Void_ItemRegister_0;

		// Token: 0x04001392 RID: 5010
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItemFromDictionary_Private_Void_ItemRegister_0;

		// Token: 0x04001393 RID: 5011
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRuntimeItems_Public_Void_0;

		// Token: 0x04001394 RID: 5012
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromRegistry_Public_Void_ItemDefinition_0;

		// Token: 0x04001395 RID: 5013
		private static readonly System.IntPtr NativeMethodInfoPtr_LogOrderedUnlocks_Public_Void_0;

		// Token: 0x04001396 RID: 5014
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008CD RID: 2253
		[System.Serializable]
		public class ObjectRegister : Il2CppSystem.Object
		{
			// Token: 0x0600C6ED RID: 50925 RVA: 0x0030BE74 File Offset: 0x0030A074
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectRegister()
			{
				Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ObjectRegister");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr);
				Registry.ObjectRegister.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, "ID");
				Registry.ObjectRegister.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, "AssetPath");
				Registry.ObjectRegister.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, "Prefab");
				Registry.ObjectRegister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr, 100666669);
			}

			// Token: 0x0600C6EE RID: 50926 RVA: 0x0030BEF0 File Offset: 0x0030A0F0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectRegister() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.ObjectRegister>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.ObjectRegister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6EF RID: 50927 RVA: 0x000606EA File Offset: 0x0005E8EA
			public ObjectRegister(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DD7 RID: 15831
			// (get) Token: 0x0600C6F0 RID: 50928 RVA: 0x0030BF2C File Offset: 0x0030A12C
			// (set) Token: 0x0600C6F1 RID: 50929 RVA: 0x000606F3 File Offset: 0x0005E8F3
			public unsafe string ID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DD8 RID: 15832
			// (get) Token: 0x0600C6F2 RID: 50930 RVA: 0x0030BF54 File Offset: 0x0030A154
			// (set) Token: 0x0600C6F3 RID: 50931 RVA: 0x00060712 File Offset: 0x0005E912
			public unsafe string AssetPath
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DD9 RID: 15833
			// (get) Token: 0x0600C6F4 RID: 50932 RVA: 0x0030BF7C File Offset: 0x0030A17C
			// (set) Token: 0x0600C6F5 RID: 50933 RVA: 0x00060731 File Offset: 0x0005E931
			public unsafe NetworkObject Prefab
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_Prefab);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ObjectRegister.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086D7 RID: 34519
			private static readonly System.IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x040086D8 RID: 34520
			private static readonly System.IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x040086D9 RID: 34521
			private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;

			// Token: 0x040086DA RID: 34522
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008CE RID: 2254
		[System.Serializable]
		public class ItemRegister : Il2CppSystem.Object
		{
			// Token: 0x0600C6F6 RID: 50934 RVA: 0x0030BFAC File Offset: 0x0030A1AC
			// Note: this type is marked as 'beforefieldinit'.
			static ItemRegister()
			{
				Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "ItemRegister");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr);
				Registry.ItemRegister.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "name");
				Registry.ItemRegister.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "ID");
				Registry.ItemRegister.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "AssetPath");
				Registry.ItemRegister.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, "Definition");
				Registry.ItemRegister.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr, 100666670);
			}

			// Token: 0x0600C6F7 RID: 50935 RVA: 0x0030C03C File Offset: 0x0030A23C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemRegister() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.ItemRegister>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.ItemRegister.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C6F8 RID: 50936 RVA: 0x00060750 File Offset: 0x0005E950
			public ItemRegister(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DDA RID: 15834
			// (get) Token: 0x0600C6F9 RID: 50937 RVA: 0x0030C078 File Offset: 0x0030A278
			// (set) Token: 0x0600C6FA RID: 50938 RVA: 0x00060759 File Offset: 0x0005E959
			public unsafe string name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DDB RID: 15835
			// (get) Token: 0x0600C6FB RID: 50939 RVA: 0x0030C0A0 File Offset: 0x0030A2A0
			// (set) Token: 0x0600C6FC RID: 50940 RVA: 0x00060778 File Offset: 0x0005E978
			public unsafe string ID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DDC RID: 15836
			// (get) Token: 0x0600C6FD RID: 50941 RVA: 0x0030C0C8 File Offset: 0x0030A2C8
			// (set) Token: 0x0600C6FE RID: 50942 RVA: 0x00060797 File Offset: 0x0005E997
			public unsafe string AssetPath
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DDD RID: 15837
			// (get) Token: 0x0600C6FF RID: 50943 RVA: 0x0030C0F0 File Offset: 0x0030A2F0
			// (set) Token: 0x0600C700 RID: 50944 RVA: 0x000607B6 File Offset: 0x0005E9B6
			public unsafe ItemDefinition Definition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_Definition);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.ItemRegister.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086DB RID: 34523
			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040086DC RID: 34524
			private static readonly System.IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x040086DD RID: 34525
			private static readonly System.IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x040086DE RID: 34526
			private static readonly System.IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x040086DF RID: 34527
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008CF RID: 2255
		[ObfuscatedName("ScheduleOne.Registry+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C701 RID: 50945 RVA: 0x0030C120 File Offset: 0x0030A320
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Registry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr);
				Registry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9");
				Registry.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9__20_0");
				Registry.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, "<>9__25_0");
				Registry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100666672);
				Registry.__c.NativeMethodInfoPtr__GetAllItems_b__20_0_Internal_ItemDefinition_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100666673);
				Registry.__c.NativeMethodInfoPtr__LogOrderedUnlocks_b__25_0_Internal_Int32_ItemDefinition_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr, 100666674);
			}

			// Token: 0x0600C702 RID: 50946 RVA: 0x0030C1C4 File Offset: 0x0030A3C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C703 RID: 50947 RVA: 0x0030C200 File Offset: 0x0030A400
			[CallerCount(0)]
			public unsafe ItemDefinition _GetAllItems_b__20_0(Registry.ItemRegister x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__GetAllItems_b__20_0_Internal_ItemDefinition_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}

			// Token: 0x0600C704 RID: 50948 RVA: 0x0030C250 File Offset: 0x0030A450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107628, XrefRangeEnd = 107632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _LogOrderedUnlocks_b__25_0(ItemDefinition x, ItemDefinition y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Registry.__c.NativeMethodInfoPtr__LogOrderedUnlocks_b__25_0_Internal_Int32_ItemDefinition_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C705 RID: 50949 RVA: 0x000607D5 File Offset: 0x0005E9D5
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DDE RID: 15838
			// (get) Token: 0x0600C706 RID: 50950 RVA: 0x0030C2B0 File Offset: 0x0030A4B0
			// (set) Token: 0x0600C707 RID: 50951 RVA: 0x000607DE File Offset: 0x0005E9DE
			public unsafe static Registry.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Registry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DDF RID: 15839
			// (get) Token: 0x0600C708 RID: 50952 RVA: 0x0030C2D8 File Offset: 0x0030A4D8
			// (set) Token: 0x0600C709 RID: 50953 RVA: 0x000607F0 File Offset: 0x0005E9F0
			public unsafe static Il2CppSystem.Converter<Registry.ItemRegister, ItemDefinition> __9__20_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Converter<Registry.ItemRegister, ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE0 RID: 15840
			// (get) Token: 0x0600C70A RID: 50954 RVA: 0x0030C300 File Offset: 0x0030A500
			// (set) Token: 0x0600C70B RID: 50955 RVA: 0x00060802 File Offset: 0x0005EA02
			public unsafe static Il2CppSystem.Comparison<ItemDefinition> __9__25_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Registry.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Registry.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086E0 RID: 34528
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040086E1 RID: 34529
			private static readonly System.IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x040086E2 RID: 34530
			private static readonly System.IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x040086E3 RID: 34531
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086E4 RID: 34532
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAllItems_b__20_0_Internal_ItemDefinition_ItemRegister_0;

			// Token: 0x040086E5 RID: 34533
			private static readonly System.IntPtr NativeMethodInfoPtr__LogOrderedUnlocks_b__25_0_Internal_Int32_ItemDefinition_ItemDefinition_0;
		}

		// Token: 0x020008D0 RID: 2256
		[ObfuscatedName("ScheduleOne.Registry+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C70C RID: 50956 RVA: 0x0030C328 File Offset: 0x0030A528
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<Registry.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c__DisplayClass10_0>.NativeClassPtr);
				Registry.__c__DisplayClass10_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c__DisplayClass10_0>.NativeClassPtr, "id");
				Registry.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass10_0>.NativeClassPtr, 100666675);
				Registry.__c__DisplayClass10_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_ObjectRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass10_0>.NativeClassPtr, 100666676);
			}

			// Token: 0x0600C70D RID: 50957 RVA: 0x0030C390 File Offset: 0x0030A590
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C70E RID: 50958 RVA: 0x0030C3CC File Offset: 0x0030A5CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107632, XrefRangeEnd = 107635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPrefab_b__0(Registry.ObjectRegister x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass10_0.NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_ObjectRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C70F RID: 50959 RVA: 0x00060814 File Offset: 0x0005EA14
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE1 RID: 15841
			// (get) Token: 0x0600C710 RID: 50960 RVA: 0x0030C41C File Offset: 0x0030A61C
			// (set) Token: 0x0600C711 RID: 50961 RVA: 0x0006081D File Offset: 0x0005EA1D
			public unsafe string id
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass10_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass10_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040086E6 RID: 34534
			private static readonly System.IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040086E7 RID: 34535
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086E8 RID: 34536
			private static readonly System.IntPtr NativeMethodInfoPtr__GetPrefab_b__0_Internal_Boolean_ObjectRegister_0;
		}

		// Token: 0x020008D1 RID: 2257
		[ObfuscatedName("ScheduleOne.Registry+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C712 RID: 50962 RVA: 0x0030C444 File Offset: 0x0030A644
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<Registry.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Registry>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registry.__c__DisplayClass24_0>.NativeClassPtr);
				Registry.__c__DisplayClass24_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registry.__c__DisplayClass24_0>.NativeClassPtr, "item");
				Registry.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass24_0>.NativeClassPtr, 100666677);
				Registry.__c__DisplayClass24_0.NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Registry.__c__DisplayClass24_0>.NativeClassPtr, 100666678);
			}

			// Token: 0x0600C713 RID: 50963 RVA: 0x0030C4AC File Offset: 0x0030A6AC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registry.__c__DisplayClass24_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C714 RID: 50964 RVA: 0x0030C4E8 File Offset: 0x0030A6E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107635, XrefRangeEnd = 107640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveFromRegistry_b__0(Registry.ItemRegister x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Registry.__c__DisplayClass24_0.NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C715 RID: 50965 RVA: 0x0006083C File Offset: 0x0005EA3C
			public __c__DisplayClass24_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE2 RID: 15842
			// (get) Token: 0x0600C716 RID: 50966 RVA: 0x0030C538 File Offset: 0x0030A738
			// (set) Token: 0x0600C717 RID: 50967 RVA: 0x00060845 File Offset: 0x0005EA45
			public unsafe ItemDefinition item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass24_0.NativeFieldInfoPtr_item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Registry.__c__DisplayClass24_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086E9 RID: 34537
			private static readonly System.IntPtr NativeFieldInfoPtr_item;

			// Token: 0x040086EA RID: 34538
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086EB RID: 34539
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveFromRegistry_b__0_Internal_Boolean_ItemRegister_0;
		}

		// Token: 0x020008D2 RID: 2258
		private sealed class MethodInfoStoreGeneric_GetItem_Public_Static_T_String_0<T>
		{
			// Token: 0x040086EC RID: 34540
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Registry.NativeMethodInfoPtr_GetItem_Public_Static_T_String_0, Il2CppClassPointerStore<Registry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
