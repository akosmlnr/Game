using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003B9 RID: 953
	public class RouteListField : ConfigField
	{
		// Token: 0x060049B4 RID: 18868 RVA: 0x00169B60 File Offset: 0x00167D60
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListField()
		{
			Il2CppClassPointerStore<RouteListField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "RouteListField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListField>.NativeClassPtr);
			RouteListField.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "Routes");
			RouteListField.NativeFieldInfoPtr_MaxRoutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "MaxRoutes");
			RouteListField.NativeFieldInfoPtr_onListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "onListChanged");
			RouteListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672484);
			RouteListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672485);
			RouteListField.NativeMethodInfoPtr_Replicate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672486);
			RouteListField.NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672487);
			RouteListField.NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672488);
			RouteListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672489);
			RouteListField.NativeMethodInfoPtr_GetData_Public_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672490);
			RouteListField.NativeMethodInfoPtr_Load_Public_Void_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672491);
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x00169C6C File Offset: 0x00167E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166465, RefRangeEnd = 166466, XrefRangeStart = 166450, XrefRangeEnd = 166465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x00169CB8 File Offset: 0x00167EB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 166483, RefRangeEnd = 166488, XrefRangeStart = 166466, XrefRangeEnd = 166483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetList(List<AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bypassSequenceCheck;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x00169D18 File Offset: 0x00167F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166495, RefRangeEnd = 166496, XrefRangeStart = 166488, XrefRangeEnd = 166495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Replicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_Replicate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049B8 RID: 18872 RVA: 0x00169D4C File Offset: 0x00167F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166513, RefRangeEnd = 166514, XrefRangeStart = 166496, XrefRangeEnd = 166513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(AdvancedTransitRoute item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049B9 RID: 18873 RVA: 0x00169D90 File Offset: 0x00167F90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166527, RefRangeEnd = 166529, XrefRangeStart = 166514, XrefRangeEnd = 166527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(AdvancedTransitRoute item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00169DD4 File Offset: 0x00167FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166529, XrefRangeEnd = 166530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RouteListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x00169E1C File Offset: 0x0016801C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166551, RefRangeEnd = 166552, XrefRangeStart = 166530, XrefRangeEnd = 166551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_GetData_Public_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListData>(intPtr2) : null;
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x00169E5C File Offset: 0x0016805C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166638, RefRangeEnd = 166640, XrefRangeStart = 166552, XrefRangeEnd = 166638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(RouteListData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_Load_Public_Void_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00023744 File Offset: 0x00021944
		public RouteListField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x060049BE RID: 18878 RVA: 0x00169EA0 File Offset: 0x001680A0
		// (set) Token: 0x060049BF RID: 18879 RVA: 0x0002374D File Offset: 0x0002194D
		public unsafe List<AdvancedTransitRoute> Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdvancedTransitRoute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x060049C0 RID: 18880 RVA: 0x00169ED0 File Offset: 0x001680D0
		// (set) Token: 0x060049C1 RID: 18881 RVA: 0x0002376C File Offset: 0x0002196C
		public unsafe int MaxRoutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_MaxRoutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_MaxRoutes)) = value;
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x060049C2 RID: 18882 RVA: 0x00169EF8 File Offset: 0x001680F8
		// (set) Token: 0x060049C3 RID: 18883 RVA: 0x00023787 File Offset: 0x00021987
		public unsafe UnityEvent<List<AdvancedTransitRoute>> onListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_onListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<List<AdvancedTransitRoute>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_onListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031A5 RID: 12709
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x040031A6 RID: 12710
		private static readonly IntPtr NativeFieldInfoPtr_MaxRoutes;

		// Token: 0x040031A7 RID: 12711
		private static readonly IntPtr NativeFieldInfoPtr_onListChanged;

		// Token: 0x040031A8 RID: 12712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040031A9 RID: 12713
		private static readonly IntPtr NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0;

		// Token: 0x040031AA RID: 12714
		private static readonly IntPtr NativeMethodInfoPtr_Replicate_Public_Void_0;

		// Token: 0x040031AB RID: 12715
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040031AC RID: 12716
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040031AD RID: 12717
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040031AE RID: 12718
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_RouteListData_0;

		// Token: 0x040031AF RID: 12719
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_RouteListData_0;
	}
}
