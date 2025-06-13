using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007A4 RID: 1956
	[System.Serializable]
	public class MapRegionData : Il2CppSystem.Object
	{
		// Token: 0x0600B92D RID: 47405 RVA: 0x002E3940 File Offset: 0x002E1B40
		// Note: this type is marked as 'beforefieldinit'.
		static MapRegionData()
		{
			Il2CppClassPointerStore<MapRegionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MapRegionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr);
			MapRegionData.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "Region");
			MapRegionData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "Name");
			MapRegionData.NativeFieldInfoPtr_RankRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RankRequirement");
			MapRegionData.NativeFieldInfoPtr_StartingNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "StartingNPCs");
			MapRegionData.NativeFieldInfoPtr_RegionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionSprite");
			MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionDeliveryLocations");
			MapRegionData.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100686226);
			MapRegionData.NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100686227);
			MapRegionData.NativeMethodInfoPtr_SetUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100686228);
			MapRegionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100686229);
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x0600B92E RID: 47406 RVA: 0x002E3A38 File Offset: 0x002E1C38
		public unsafe bool IsUnlocked
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 316180, RefRangeEnd = 316184, XrefRangeStart = 316176, XrefRangeEnd = 316180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600B92F RID: 47407 RVA: 0x002E3A74 File Offset: 0x002E1C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316213, RefRangeEnd = 316214, XrefRangeStart = 316184, XrefRangeEnd = 316213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x002E3AB4 File Offset: 0x002E1CB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316215, RefRangeEnd = 316217, XrefRangeStart = 316214, XrefRangeEnd = 316215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_SetUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x002E3AE8 File Offset: 0x002E1CE8
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapRegionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B932 RID: 47410 RVA: 0x0005A78D File Offset: 0x0005898D
		public MapRegionData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x0600B933 RID: 47411 RVA: 0x002E3B24 File Offset: 0x002E1D24
		// (set) Token: 0x0600B934 RID: 47412 RVA: 0x0005A796 File Offset: 0x00058996
		public unsafe EMapRegion Region
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Region)) = value;
			}
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x0600B935 RID: 47413 RVA: 0x002E3B4C File Offset: 0x002E1D4C
		// (set) Token: 0x0600B936 RID: 47414 RVA: 0x0005A7B1 File Offset: 0x000589B1
		public unsafe string Name
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x0600B937 RID: 47415 RVA: 0x002E3B74 File Offset: 0x002E1D74
		// (set) Token: 0x0600B938 RID: 47416 RVA: 0x0005A7D0 File Offset: 0x000589D0
		public unsafe FullRank RankRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RankRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RankRequirement)) = value;
			}
		}

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x0600B939 RID: 47417 RVA: 0x002E3B9C File Offset: 0x002E1D9C
		// (set) Token: 0x0600B93A RID: 47418 RVA: 0x0005A7EB File Offset: 0x000589EB
		public unsafe Il2CppReferenceArray<NPC> StartingNPCs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_StartingNPCs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_StartingNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x0600B93B RID: 47419 RVA: 0x002E3BCC File Offset: 0x002E1DCC
		// (set) Token: 0x0600B93C RID: 47420 RVA: 0x0005A80A File Offset: 0x00058A0A
		public unsafe Sprite RegionSprite
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionSprite);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0600B93D RID: 47421 RVA: 0x002E3BFC File Offset: 0x002E1DFC
		// (set) Token: 0x0600B93E RID: 47422 RVA: 0x0005A829 File Offset: 0x00058A29
		public unsafe Il2CppReferenceArray<DeliveryLocation> RegionDeliveryLocations
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryLocation>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007CF5 RID: 31989
		private static readonly System.IntPtr NativeFieldInfoPtr_Region;

		// Token: 0x04007CF6 RID: 31990
		private static readonly System.IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04007CF7 RID: 31991
		private static readonly System.IntPtr NativeFieldInfoPtr_RankRequirement;

		// Token: 0x04007CF8 RID: 31992
		private static readonly System.IntPtr NativeFieldInfoPtr_StartingNPCs;

		// Token: 0x04007CF9 RID: 31993
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionSprite;

		// Token: 0x04007CFA RID: 31994
		private static readonly System.IntPtr NativeFieldInfoPtr_RegionDeliveryLocations;

		// Token: 0x04007CFB RID: 31995
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0;

		// Token: 0x04007CFC RID: 31996
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0;

		// Token: 0x04007CFD RID: 31997
		private static readonly System.IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_0;

		// Token: 0x04007CFE RID: 31998
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C56 RID: 3158
		[ObfuscatedName("ScheduleOne.Map.MapRegionData+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E56C RID: 58732 RVA: 0x003628F8 File Offset: 0x00360AF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr);
				MapRegionData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, "<>9");
				MapRegionData.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, "<>9__8_0");
				MapRegionData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, 100686231);
				MapRegionData.__c.NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__8_0_Internal_Boolean_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, 100686232);
			}

			// Token: 0x0600E56D RID: 58733 RVA: 0x00362974 File Offset: 0x00360B74
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E56E RID: 58734 RVA: 0x003629B0 File Offset: 0x00360BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316175, XrefRangeEnd = 316176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomUnscheduledDeliveryLocation_b__8_0(DeliveryLocation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MapRegionData.__c.NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__8_0_Internal_Boolean_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E56F RID: 58735 RVA: 0x0006F91B File Offset: 0x0006DB1B
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046C8 RID: 18120
			// (get) Token: 0x0600E570 RID: 58736 RVA: 0x00362A00 File Offset: 0x00360C00
			// (set) Token: 0x0600E571 RID: 58737 RVA: 0x0006F924 File Offset: 0x0006DB24
			public unsafe static MapRegionData.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MapRegionData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapRegionData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MapRegionData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C9 RID: 18121
			// (get) Token: 0x0600E572 RID: 58738 RVA: 0x00362A28 File Offset: 0x00360C28
			// (set) Token: 0x0600E573 RID: 58739 RVA: 0x0006F936 File Offset: 0x0006DB36
			public unsafe static Il2CppSystem.Func<DeliveryLocation, bool> __9__8_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MapRegionData.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<DeliveryLocation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MapRegionData.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099B1 RID: 39345
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040099B2 RID: 39346
			private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040099B3 RID: 39347
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099B4 RID: 39348
			private static readonly System.IntPtr NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__8_0_Internal_Boolean_DeliveryLocation_0;
		}
	}
}
