using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005B6 RID: 1462
	public class WeedStationItem : StationItem
	{
		// Token: 0x06007FC2 RID: 32706 RVA: 0x00225878 File Offset: 0x00223A78
		// Note: this type is marked as 'beforefieldinit'.
		static WeedStationItem()
		{
			Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "WeedStationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr);
			WeedStationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr, "Visuals");
			WeedStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr, 100679376);
			WeedStationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr, 100679377);
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x002258E4 File Offset: 0x00223AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241997, XrefRangeEnd = 242003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FC4 RID: 32708 RVA: 0x00225934 File Offset: 0x00223B34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 241857, RefRangeEnd = 241861, XrefRangeStart = 241857, XrefRangeEnd = 241861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedStationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedStationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FC5 RID: 32709 RVA: 0x0003C79C File Offset: 0x0003A99C
		public WeedStationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x06007FC6 RID: 32710 RVA: 0x00225970 File Offset: 0x00223B70
		// (set) Token: 0x06007FC7 RID: 32711 RVA: 0x0003C7A5 File Offset: 0x0003A9A5
		public unsafe Il2CppReferenceArray<FilledPackagingVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedStationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedStationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040056ED RID: 22253
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040056EE RID: 22254
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x040056EF RID: 22255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
