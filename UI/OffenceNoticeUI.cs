using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Police;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200067E RID: 1662
	public class OffenceNoticeUI : Singleton<OffenceNoticeUI>
	{
		// Token: 0x06009359 RID: 37721 RVA: 0x00263D2C File Offset: 0x00261F2C
		// Note: this type is marked as 'beforefieldinit'.
		static OffenceNoticeUI()
		{
			Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "OffenceNoticeUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr);
			OffenceNoticeUI.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "container");
			OffenceNoticeUI.NativeFieldInfoPtr_charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "charges");
			OffenceNoticeUI.NativeFieldInfoPtr_penalties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, "penalties");
			OffenceNoticeUI.NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100681646);
			OffenceNoticeUI.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100681647);
			OffenceNoticeUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr, 100681648);
		}

		// Token: 0x0600935A RID: 37722 RVA: 0x00263DD4 File Offset: 0x00261FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266307, XrefRangeEnd = 266358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOffenceNotice(Offense offence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(offence);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x00263E18 File Offset: 0x00262018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266358, XrefRangeEnd = 266387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600935C RID: 37724 RVA: 0x00263E4C File Offset: 0x0026204C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266387, XrefRangeEnd = 266402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffenceNoticeUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffenceNoticeUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffenceNoticeUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600935D RID: 37725 RVA: 0x00046EE9 File Offset: 0x000450E9
		public OffenceNoticeUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x0600935E RID: 37726 RVA: 0x00263E88 File Offset: 0x00262088
		// (set) Token: 0x0600935F RID: 37727 RVA: 0x00046EF2 File Offset: 0x000450F2
		public unsafe GameObject container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x06009360 RID: 37728 RVA: 0x00263EB8 File Offset: 0x002620B8
		// (set) Token: 0x06009361 RID: 37729 RVA: 0x00046F11 File Offset: 0x00045111
		public unsafe List<Text> charges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_charges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_charges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x06009362 RID: 37730 RVA: 0x00263EE8 File Offset: 0x002620E8
		// (set) Token: 0x06009363 RID: 37731 RVA: 0x00046F30 File Offset: 0x00045130
		public unsafe List<Text> penalties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_penalties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffenceNoticeUI.NativeFieldInfoPtr_penalties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063A3 RID: 25507
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040063A4 RID: 25508
		private static readonly IntPtr NativeFieldInfoPtr_charges;

		// Token: 0x040063A5 RID: 25509
		private static readonly IntPtr NativeFieldInfoPtr_penalties;

		// Token: 0x040063A6 RID: 25510
		private static readonly IntPtr NativeMethodInfoPtr_ShowOffenceNotice_Public_Void_Offense_0;

		// Token: 0x040063A7 RID: 25511
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x040063A8 RID: 25512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
