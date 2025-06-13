using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000788 RID: 1928
	[Serializable]
	public class WateringCanDefinition : StorableItemDefinition
	{
		// Token: 0x0600B744 RID: 46916 RVA: 0x002DDF14 File Offset: 0x002DC114
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanDefinition()
		{
			Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WateringCanDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr);
			WateringCanDefinition.NativeFieldInfoPtr_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, "Capacity");
			WateringCanDefinition.NativeFieldInfoPtr_FunctionalWateringCanPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, "FunctionalWateringCanPrefab");
			WateringCanDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, 100686053);
			WateringCanDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr, 100686054);
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x002DDF94 File Offset: 0x002DC194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314803, XrefRangeEnd = 314807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x002DDFEC File Offset: 0x002DC1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x000596D8 File Offset: 0x000578D8
		public WateringCanDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600B748 RID: 46920 RVA: 0x002DE028 File Offset: 0x002DC228
		// (set) Token: 0x0600B749 RID: 46921 RVA: 0x000596E1 File Offset: 0x000578E1
		public unsafe static float Capacity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WateringCanDefinition.NativeFieldInfoPtr_Capacity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WateringCanDefinition.NativeFieldInfoPtr_Capacity, (void*)(&value));
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600B74A RID: 46922 RVA: 0x002DE044 File Offset: 0x002DC244
		// (set) Token: 0x0600B74B RID: 46923 RVA: 0x000596EF File Offset: 0x000578EF
		public unsafe GameObject FunctionalWateringCanPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanDefinition.NativeFieldInfoPtr_FunctionalWateringCanPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanDefinition.NativeFieldInfoPtr_FunctionalWateringCanPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BC8 RID: 31688
		private static readonly IntPtr NativeFieldInfoPtr_Capacity;

		// Token: 0x04007BC9 RID: 31689
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalWateringCanPrefab;

		// Token: 0x04007BCA RID: 31690
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04007BCB RID: 31691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
