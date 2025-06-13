using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000667 RID: 1639
	public class CashSlotUI : ItemSlotUI
	{
		// Token: 0x06009042 RID: 36930 RVA: 0x0025AE18 File Offset: 0x00259018
		// Note: this type is marked as 'beforefieldinit'.
		static CashSlotUI()
		{
			Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CashSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr);
			CashSlotUI.NativeFieldInfoPtr_cashInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr, "cashInstance");
			CashSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr, 100681310);
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x0025AE70 File Offset: 0x00259070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262403, XrefRangeEnd = 262404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x00045128 File Offset: 0x00043328
		public CashSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x06009045 RID: 36933 RVA: 0x0025AEAC File Offset: 0x002590AC
		// (set) Token: 0x06009046 RID: 36934 RVA: 0x00045131 File Offset: 0x00043331
		public unsafe CashInstance cashInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashSlotUI.NativeFieldInfoPtr_cashInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashSlotUI.NativeFieldInfoPtr_cashInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040061B8 RID: 25016
		private static readonly IntPtr NativeFieldInfoPtr_cashInstance;

		// Token: 0x040061B9 RID: 25017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
