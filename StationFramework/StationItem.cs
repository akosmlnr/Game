using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005B4 RID: 1460
	public class StationItem : MonoBehaviour
	{
		// Token: 0x06007F93 RID: 32659 RVA: 0x00224F3C File Offset: 0x0022313C
		// Note: this type is marked as 'beforefieldinit'.
		static StationItem()
		{
			Il2CppClassPointerStore<StationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "StationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem>.NativeClassPtr);
			StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<ActiveModules>k__BackingField");
			StationItem.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "Modules");
			StationItem.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "TrashPrefab");
			StationItem.NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679348);
			StationItem.NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679349);
			StationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679350);
			StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679351);
			StationItem.NativeMethodInfoPtr_ActivateModule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679352);
			StationItem.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679353);
			StationItem.NativeMethodInfoPtr_HasModule_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679354);
			StationItem.NativeMethodInfoPtr_GetModule_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679355);
			StationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679356);
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x06007F94 RID: 32660 RVA: 0x0022505C File Offset: 0x0022325C
		// (set) Token: 0x06007F95 RID: 32661 RVA: 0x0022509C File Offset: 0x0022329C
		public unsafe List<ItemModule> ActiveModules
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007F96 RID: 32662 RVA: 0x002250E0 File Offset: 0x002232E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241715, XrefRangeEnd = 241720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x0022511C File Offset: 0x0022331C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x0022516C File Offset: 0x0022336C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 241742, RefRangeEnd = 241750, XrefRangeStart = 241720, XrefRangeEnd = 241742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_ActivateModule_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x002251A0 File Offset: 0x002233A0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 241755, RefRangeEnd = 241764, XrefRangeStart = 241750, XrefRangeEnd = 241755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x002251D4 File Offset: 0x002233D4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 241782, RefRangeEnd = 241794, XrefRangeStart = 241764, XrefRangeEnd = 241782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_HasModule_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007F9B RID: 32667 RVA: 0x00225210 File Offset: 0x00223410
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 241812, RefRangeEnd = 241849, XrefRangeStart = 241794, XrefRangeEnd = 241812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_GetModule_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06007F9C RID: 32668 RVA: 0x0022524C File Offset: 0x0022344C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 241857, RefRangeEnd = 241861, XrefRangeStart = 241849, XrefRangeEnd = 241857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F9D RID: 32669 RVA: 0x0003C613 File Offset: 0x0003A813
		public StationItem(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x06007F9E RID: 32670 RVA: 0x00225288 File Offset: 0x00223488
		// (set) Token: 0x06007F9F RID: 32671 RVA: 0x0003C61C File Offset: 0x0003A81C
		public unsafe List<ItemModule> _ActiveModules_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x06007FA0 RID: 32672 RVA: 0x002252B8 File Offset: 0x002234B8
		// (set) Token: 0x06007FA1 RID: 32673 RVA: 0x0003C63B File Offset: 0x0003A83B
		public unsafe List<ItemModule> Modules
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_Modules);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x06007FA2 RID: 32674 RVA: 0x002252E8 File Offset: 0x002234E8
		// (set) Token: 0x06007FA3 RID: 32675 RVA: 0x0003C65A File Offset: 0x0003A85A
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_TrashPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040056CF RID: 22223
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveModules_k__BackingField;

		// Token: 0x040056D0 RID: 22224
		private static readonly System.IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x040056D1 RID: 22225
		private static readonly System.IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x040056D2 RID: 22226
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0;

		// Token: 0x040056D3 RID: 22227
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0;

		// Token: 0x040056D4 RID: 22228
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040056D5 RID: 22229
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0;

		// Token: 0x040056D6 RID: 22230
		private static readonly System.IntPtr NativeMethodInfoPtr_ActivateModule_Public_Void_0;

		// Token: 0x040056D7 RID: 22231
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040056D8 RID: 22232
		private static readonly System.IntPtr NativeMethodInfoPtr_HasModule_Public_Boolean_0;

		// Token: 0x040056D9 RID: 22233
		private static readonly System.IntPtr NativeMethodInfoPtr_GetModule_Public_T_0;

		// Token: 0x040056DA RID: 22234
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B09 RID: 2825
		[ObfuscatedName("ScheduleOne.StationFramework.StationItem+<>c__10`1")]
		[System.Serializable]
		public sealed class __c__10<T> : Il2CppSystem.Object where T : ItemModule
		{
			// Token: 0x0600D910 RID: 55568 RVA: 0x0033F5E8 File Offset: 0x0033D7E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__10()
			{
				Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<>c__10`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
				{
					Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr);
				StationItem.__c__10<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, "<>9");
				StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, "<>9__10_0");
				StationItem.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, 100679358);
				StationItem.__c__10<T>.NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, 100679359);
			}

			// Token: 0x0600D911 RID: 55569 RVA: 0x0033F6A0 File Offset: 0x0033D8A0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__10() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D912 RID: 55570 RVA: 0x0033F6DC File Offset: 0x0033D8DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241698, XrefRangeEnd = 241705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasModule_b__10_0(ItemModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__10<T>.NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D913 RID: 55571 RVA: 0x0006957C File Offset: 0x0006777C
			public __c__10(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042FF RID: 17151
			// (get) Token: 0x0600D914 RID: 55572 RVA: 0x0033F72C File Offset: 0x0033D92C
			// (set) Token: 0x0600D915 RID: 55573 RVA: 0x00069585 File Offset: 0x00067785
			public unsafe static StationItem.__c__10<T> __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem.__c__10<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004300 RID: 17152
			// (get) Token: 0x0600D916 RID: 55574 RVA: 0x0033F754 File Offset: 0x0033D954
			// (set) Token: 0x0600D917 RID: 55575 RVA: 0x00069597 File Offset: 0x00067797
			public unsafe static Il2CppSystem.Predicate<ItemModule> __9__10_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ItemModule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400923E RID: 37438
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400923F RID: 37439
			private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04009240 RID: 37440
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009241 RID: 37441
			private static readonly System.IntPtr NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0;
		}

		// Token: 0x02000B0A RID: 2826
		[ObfuscatedName("ScheduleOne.StationFramework.StationItem+<>c__11`1")]
		[System.Serializable]
		public sealed class __c__11<T> : Il2CppSystem.Object where T : ItemModule
		{
			// Token: 0x0600D918 RID: 55576 RVA: 0x0033F77C File Offset: 0x0033D97C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__11()
			{
				Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<>c__11`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
				{
					Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr);
				StationItem.__c__11<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, "<>9");
				StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, "<>9__11_0");
				StationItem.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, 100679361);
				StationItem.__c__11<T>.NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, 100679362);
			}

			// Token: 0x0600D919 RID: 55577 RVA: 0x0033F834 File Offset: 0x0033DA34
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__11() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D91A RID: 55578 RVA: 0x0033F870 File Offset: 0x0033DA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241705, XrefRangeEnd = 241715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetModule_b__11_0(ItemModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__11<T>.NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D91B RID: 55579 RVA: 0x000695A9 File Offset: 0x000677A9
			public __c__11(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004301 RID: 17153
			// (get) Token: 0x0600D91C RID: 55580 RVA: 0x0033F8C0 File Offset: 0x0033DAC0
			// (set) Token: 0x0600D91D RID: 55581 RVA: 0x000695B2 File Offset: 0x000677B2
			public unsafe static StationItem.__c__11<T> __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem.__c__11<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004302 RID: 17154
			// (get) Token: 0x0600D91E RID: 55582 RVA: 0x0033F8E8 File Offset: 0x0033DAE8
			// (set) Token: 0x0600D91F RID: 55583 RVA: 0x000695C4 File Offset: 0x000677C4
			public unsafe static Il2CppSystem.Predicate<ItemModule> __9__11_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ItemModule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009242 RID: 37442
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009243 RID: 37443
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009244 RID: 37444
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009245 RID: 37445
			private static readonly System.IntPtr NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0;
		}

		// Token: 0x02000B0B RID: 2827
		private sealed class MethodInfoStoreGeneric_ActivateModule_Public_Void_0<T>
		{
			// Token: 0x04009246 RID: 37446
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_ActivateModule_Public_Void_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B0C RID: 2828
		private sealed class MethodInfoStoreGeneric_HasModule_Public_Boolean_0<T>
		{
			// Token: 0x04009247 RID: 37447
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_HasModule_Public_Boolean_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B0D RID: 2829
		private sealed class MethodInfoStoreGeneric_GetModule_Public_T_0<T>
		{
			// Token: 0x04009248 RID: 37448
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_GetModule_Public_T_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
