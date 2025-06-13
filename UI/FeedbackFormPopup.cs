using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065E RID: 1630
	public class FeedbackFormPopup : MonoBehaviour
	{
		// Token: 0x06008F1C RID: 36636 RVA: 0x00257950 File Offset: 0x00255B50
		// Note: this type is marked as 'beforefieldinit'.
		static FeedbackFormPopup()
		{
			Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "FeedbackFormPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr);
			FeedbackFormPopup.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, "Label");
			FeedbackFormPopup.NativeFieldInfoPtr_AutoClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, "AutoClose");
			FeedbackFormPopup.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, "closeTime");
			FeedbackFormPopup.NativeMethodInfoPtr_Open_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100681175);
			FeedbackFormPopup.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100681176);
			FeedbackFormPopup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100681177);
			FeedbackFormPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100681178);
		}

		// Token: 0x06008F1D RID: 36637 RVA: 0x00257A0C File Offset: 0x00255C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261211, XrefRangeEnd = 261218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr_Open_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F1E RID: 36638 RVA: 0x00257A50 File Offset: 0x00255C50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199161, RefRangeEnd = 199164, XrefRangeStart = 199161, XrefRangeEnd = 199164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F1F RID: 36639 RVA: 0x00257A84 File Offset: 0x00255C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261218, XrefRangeEnd = 261221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F20 RID: 36640 RVA: 0x00257AB8 File Offset: 0x00255CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeedbackFormPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F21 RID: 36641 RVA: 0x000445F0 File Offset: 0x000427F0
		public FeedbackFormPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x06008F22 RID: 36642 RVA: 0x00257AF4 File Offset: 0x00255CF4
		// (set) Token: 0x06008F23 RID: 36643 RVA: 0x000445F9 File Offset: 0x000427F9
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x06008F24 RID: 36644 RVA: 0x00257B24 File Offset: 0x00255D24
		// (set) Token: 0x06008F25 RID: 36645 RVA: 0x00044618 File Offset: 0x00042818
		public unsafe bool AutoClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_AutoClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_AutoClose)) = value;
			}
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x06008F26 RID: 36646 RVA: 0x00257B4C File Offset: 0x00255D4C
		// (set) Token: 0x06008F27 RID: 36647 RVA: 0x00044633 File Offset: 0x00042833
		public unsafe float closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x04006104 RID: 24836
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006105 RID: 24837
		private static readonly IntPtr NativeFieldInfoPtr_AutoClose;

		// Token: 0x04006106 RID: 24838
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04006107 RID: 24839
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_0;

		// Token: 0x04006108 RID: 24840
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006109 RID: 24841
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400610A RID: 24842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
