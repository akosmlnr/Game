using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029E RID: 670
	[System.Serializable]
	public class RouteListData : Il2CppSystem.Object
	{
		// Token: 0x06003124 RID: 12580 RVA: 0x0011066C File Offset: 0x0010E86C
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListData()
		{
			Il2CppClassPointerStore<RouteListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "RouteListData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListData>.NativeClassPtr);
			RouteListData.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListData>.NativeClassPtr, "Routes");
			RouteListData.NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListData>.NativeClassPtr, 100669035);
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x001106C4 File Offset: 0x0010E8C4
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19232, RefRangeEnd = 19435, XrefRangeStart = 19232, XrefRangeEnd = 19435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListData(List<AdvancedTransitRouteData> routes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routes);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListData.NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00019CC0 File Offset: 0x00017EC0
		public RouteListData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x00110710 File Offset: 0x0010E910
		// (set) Token: 0x06003128 RID: 12584 RVA: 0x00019CC9 File Offset: 0x00017EC9
		public unsafe List<AdvancedTransitRouteData> Routes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListData.NativeFieldInfoPtr_Routes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdvancedTransitRouteData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListData.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400204C RID: 8268
		private static readonly System.IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x0400204D RID: 8269
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0;
	}
}
