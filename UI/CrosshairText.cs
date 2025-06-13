using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000653 RID: 1619
	public class CrosshairText : MonoBehaviour
	{
		// Token: 0x06008DF0 RID: 36336 RVA: 0x00253EE4 File Offset: 0x002520E4
		// Note: this type is marked as 'beforefieldinit'.
		static CrosshairText()
		{
			Il2CppClassPointerStore<CrosshairText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CrosshairText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr);
			CrosshairText.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, "Label");
			CrosshairText.NativeFieldInfoPtr_setThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, "setThisFrame");
			CrosshairText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100681022);
			CrosshairText.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100681023);
			CrosshairText.NativeMethodInfoPtr_Show_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100681024);
			CrosshairText.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100681025);
			CrosshairText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100681026);
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x00253FA0 File Offset: 0x002521A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x00253FD4 File Offset: 0x002521D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259788, XrefRangeEnd = 259789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x00254008 File Offset: 0x00252208
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 259792, RefRangeEnd = 259795, XrefRangeStart = 259789, XrefRangeEnd = 259792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(string text, Color col = default(Color))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Show_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DF4 RID: 36340 RVA: 0x00254058 File Offset: 0x00252258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DF5 RID: 36341 RVA: 0x0025408C File Offset: 0x0025228C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrosshairText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008DF6 RID: 36342 RVA: 0x00043B60 File Offset: 0x00041D60
		public CrosshairText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x06008DF7 RID: 36343 RVA: 0x002540C8 File Offset: 0x002522C8
		// (set) Token: 0x06008DF8 RID: 36344 RVA: 0x00043B69 File Offset: 0x00041D69
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x06008DF9 RID: 36345 RVA: 0x002540F8 File Offset: 0x002522F8
		// (set) Token: 0x06008DFA RID: 36346 RVA: 0x00043B88 File Offset: 0x00041D88
		public unsafe bool setThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_setThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_setThisFrame)) = value;
			}
		}

		// Token: 0x04006044 RID: 24644
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006045 RID: 24645
		private static readonly IntPtr NativeFieldInfoPtr_setThisFrame;

		// Token: 0x04006046 RID: 24646
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006047 RID: 24647
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006048 RID: 24648
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_String_Color_0;

		// Token: 0x04006049 RID: 24649
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x0400604A RID: 24650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
