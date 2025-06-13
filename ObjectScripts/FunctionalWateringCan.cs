using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.PlayerTasks;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200077F RID: 1919
	public class FunctionalWateringCan : Pourable
	{
		// Token: 0x0600B633 RID: 46643 RVA: 0x002D9E90 File Offset: 0x002D8090
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalWateringCan()
		{
			Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "FunctionalWateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr);
			FunctionalWateringCan.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, "Visuals");
			FunctionalWateringCan.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, "itemInstance");
			FunctionalWateringCan.NativeMethodInfoPtr_Setup_Public_Void_WateringCanInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, 100685901);
			FunctionalWateringCan.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, 100685902);
			FunctionalWateringCan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, 100685903);
		}

		// Token: 0x0600B634 RID: 46644 RVA: 0x002D9F24 File Offset: 0x002D8124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313525, RefRangeEnd = 313526, XrefRangeStart = 313522, XrefRangeEnd = 313525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(WateringCanInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalWateringCan.NativeMethodInfoPtr_Setup_Public_Void_WateringCanInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B635 RID: 46645 RVA: 0x002D9F68 File Offset: 0x002D8168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313526, XrefRangeEnd = 313529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalWateringCan.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B636 RID: 46646 RVA: 0x002D9FB4 File Offset: 0x002D81B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalWateringCan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalWateringCan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x00058FFB File Offset: 0x000571FB
		public FunctionalWateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600B638 RID: 46648 RVA: 0x002D9FF0 File Offset: 0x002D81F0
		// (set) Token: 0x0600B639 RID: 46649 RVA: 0x00059004 File Offset: 0x00057204
		public unsafe WateringCanVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600B63A RID: 46650 RVA: 0x002DA020 File Offset: 0x002D8220
		// (set) Token: 0x0600B63B RID: 46651 RVA: 0x00059023 File Offset: 0x00057223
		public unsafe WateringCanInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007B03 RID: 31491
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04007B04 RID: 31492
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x04007B05 RID: 31493
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_WateringCanInstance_0;

		// Token: 0x04007B06 RID: 31494
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04007B07 RID: 31495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
