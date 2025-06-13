using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Levelling;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007A8 RID: 1960
	public class Map : Singleton<Map>
	{
		// Token: 0x0600B98B RID: 47499 RVA: 0x002E4890 File Offset: 0x002E2A90
		// Note: this type is marked as 'beforefieldinit'.
		static Map()
		{
			Il2CppClassPointerStore<Map>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Map");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map>.NativeClassPtr);
			Map.NativeFieldInfoPtr_Regions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "Regions");
			Map.NativeFieldInfoPtr_PoliceStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "PoliceStation");
			Map.NativeFieldInfoPtr_MedicalCentre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "MedicalCentre");
			Map.NativeFieldInfoPtr_TreeBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "TreeBounds");
			Map.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100686251);
			Map.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100686252);
			Map.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100686253);
			Map.NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100686254);
			Map.NativeMethodInfoPtr_GameLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100686255);
			Map.NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100686256);
			Map.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100686257);
		}

		// Token: 0x0600B98C RID: 47500 RVA: 0x002E499C File Offset: 0x002E2B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316318, XrefRangeEnd = 316378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x002E49D8 File Offset: 0x002E2BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316378, XrefRangeEnd = 316412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x002E4A14 File Offset: 0x002E2C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316412, XrefRangeEnd = 316430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x002E4A50 File Offset: 0x002E2C50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 316444, RefRangeEnd = 316450, XrefRangeStart = 316430, XrefRangeEnd = 316444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapRegionData GetRegionData(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref region;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapRegionData>(intPtr2) : null;
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x002E4A9C File Offset: 0x002E2C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316450, XrefRangeEnd = 316461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_GameLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x002E4AD0 File Offset: 0x002E2CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316461, XrefRangeEnd = 316472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRankUp(FullRank oldRank, FullRank newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref newRank;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x002E4B1C File Offset: 0x002E2D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316472, XrefRangeEnd = 316475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Map() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x0005AB3B File Offset: 0x00058D3B
		public Map(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x0600B994 RID: 47508 RVA: 0x002E4B58 File Offset: 0x002E2D58
		// (set) Token: 0x0600B995 RID: 47509 RVA: 0x0005AB44 File Offset: 0x00058D44
		public unsafe Il2CppReferenceArray<MapRegionData> Regions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_Regions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapRegionData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_Regions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x0600B996 RID: 47510 RVA: 0x002E4B88 File Offset: 0x002E2D88
		// (set) Token: 0x0600B997 RID: 47511 RVA: 0x0005AB63 File Offset: 0x00058D63
		public unsafe PoliceStation PoliceStation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_PoliceStation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_PoliceStation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x0600B998 RID: 47512 RVA: 0x002E4BB8 File Offset: 0x002E2DB8
		// (set) Token: 0x0600B999 RID: 47513 RVA: 0x0005AB82 File Offset: 0x00058D82
		public unsafe MedicalCentre MedicalCentre
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_MedicalCentre);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MedicalCentre>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_MedicalCentre), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x0600B99A RID: 47514 RVA: 0x002E4BE8 File Offset: 0x002E2DE8
		// (set) Token: 0x0600B99B RID: 47515 RVA: 0x0005ABA1 File Offset: 0x00058DA1
		public unsafe Transform TreeBounds
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_TreeBounds);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_TreeBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D2B RID: 32043
		private static readonly System.IntPtr NativeFieldInfoPtr_Regions;

		// Token: 0x04007D2C RID: 32044
		private static readonly System.IntPtr NativeFieldInfoPtr_PoliceStation;

		// Token: 0x04007D2D RID: 32045
		private static readonly System.IntPtr NativeFieldInfoPtr_MedicalCentre;

		// Token: 0x04007D2E RID: 32046
		private static readonly System.IntPtr NativeFieldInfoPtr_TreeBounds;

		// Token: 0x04007D2F RID: 32047
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007D30 RID: 32048
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007D31 RID: 32049
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04007D32 RID: 32050
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0;

		// Token: 0x04007D33 RID: 32051
		private static readonly System.IntPtr NativeMethodInfoPtr_GameLoaded_Private_Void_0;

		// Token: 0x04007D34 RID: 32052
		private static readonly System.IntPtr NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0;

		// Token: 0x04007D35 RID: 32053
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C57 RID: 3159
		[ObfuscatedName("ScheduleOne.Map.Map+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E574 RID: 58740 RVA: 0x00362A50 File Offset: 0x00360C50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Map>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr);
				Map.__c__DisplayClass4_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr, "region");
				Map.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr, 100686258);
				Map.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr, 100686259);
			}

			// Token: 0x0600E575 RID: 58741 RVA: 0x00362AB8 File Offset: 0x00360CB8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map.__c__DisplayClass4_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E576 RID: 58742 RVA: 0x00362AF4 File Offset: 0x00360CF4
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(MapRegionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E577 RID: 58743 RVA: 0x0006F948 File Offset: 0x0006DB48
			public __c__DisplayClass4_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046CA RID: 18122
			// (get) Token: 0x0600E578 RID: 58744 RVA: 0x00362B44 File Offset: 0x00360D44
			// (set) Token: 0x0600E579 RID: 58745 RVA: 0x0006F951 File Offset: 0x0006DB51
			public unsafe EMapRegion region
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass4_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass4_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x040099B5 RID: 39349
			private static readonly System.IntPtr NativeFieldInfoPtr_region;

			// Token: 0x040099B6 RID: 39350
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099B7 RID: 39351
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0;
		}

		// Token: 0x02000C58 RID: 3160
		[ObfuscatedName("ScheduleOne.Map.Map+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E57A RID: 58746 RVA: 0x00362B6C File Offset: 0x00360D6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Map>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr);
				Map.__c__DisplayClass7_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr, "region");
				Map.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr, 100686260);
				Map.__c__DisplayClass7_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr, 100686261);
			}

			// Token: 0x0600E57B RID: 58747 RVA: 0x00362BD4 File Offset: 0x00360DD4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E57C RID: 58748 RVA: 0x00362C10 File Offset: 0x00360E10
			[CallerCount(0)]
			public unsafe bool _GetRegionData_b__0(MapRegionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass7_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E57D RID: 58749 RVA: 0x0006F96C File Offset: 0x0006DB6C
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046CB RID: 18123
			// (get) Token: 0x0600E57E RID: 58750 RVA: 0x00362C60 File Offset: 0x00360E60
			// (set) Token: 0x0600E57F RID: 58751 RVA: 0x0006F975 File Offset: 0x0006DB75
			public unsafe EMapRegion region
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass7_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass7_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x040099B8 RID: 39352
			private static readonly System.IntPtr NativeFieldInfoPtr_region;

			// Token: 0x040099B9 RID: 39353
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099BA RID: 39354
			private static readonly System.IntPtr NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0;
		}
	}
}
