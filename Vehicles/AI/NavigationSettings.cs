using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000520 RID: 1312
	public class NavigationSettings : Il2CppSystem.Object
	{
		// Token: 0x060072D5 RID: 29397 RVA: 0x001FA338 File Offset: 0x001F8538
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationSettings()
		{
			Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "NavigationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr);
			NavigationSettings.NativeFieldInfoPtr_endAtRoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "endAtRoad");
			NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "ensureProximityToGraph");
			NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "teleportToGraphIfCalculationFails");
			NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, 100677809);
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x001FA3B8 File Offset: 0x001F85B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225847, XrefRangeEnd = 225848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x000364D1 File Offset: 0x000346D1
		public NavigationSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x060072D8 RID: 29400 RVA: 0x001FA3F4 File Offset: 0x001F85F4
		// (set) Token: 0x060072D9 RID: 29401 RVA: 0x000364DA File Offset: 0x000346DA
		public unsafe bool endAtRoad
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_endAtRoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_endAtRoad)) = value;
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x060072DA RID: 29402 RVA: 0x001FA41C File Offset: 0x001F861C
		// (set) Token: 0x060072DB RID: 29403 RVA: 0x000364F5 File Offset: 0x000346F5
		public unsafe bool ensureProximityToGraph
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph)) = value;
			}
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x060072DC RID: 29404 RVA: 0x001FA444 File Offset: 0x001F8644
		// (set) Token: 0x060072DD RID: 29405 RVA: 0x00036510 File Offset: 0x00034710
		public unsafe bool teleportToGraphIfCalculationFails
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails)) = value;
			}
		}

		// Token: 0x04004E76 RID: 20086
		private static readonly System.IntPtr NativeFieldInfoPtr_endAtRoad;

		// Token: 0x04004E77 RID: 20087
		private static readonly System.IntPtr NativeFieldInfoPtr_ensureProximityToGraph;

		// Token: 0x04004E78 RID: 20088
		private static readonly System.IntPtr NativeFieldInfoPtr_teleportToGraphIfCalculationFails;

		// Token: 0x04004E79 RID: 20089
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
