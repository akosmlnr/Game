using System;
using Il2CppAeLa.EasyFeedback;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065D RID: 1629
	public class FeedbackForm : FeedbackForm
	{
		// Token: 0x06008EFB RID: 36603 RVA: 0x00257230 File Offset: 0x00255430
		// Note: this type is marked as 'beforefieldinit'.
		static FeedbackForm()
		{
			Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "FeedbackForm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr);
			FeedbackForm.NativeFieldInfoPtr_ssCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "ssCoroutine");
			FeedbackForm.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "CanvasGroup");
			FeedbackForm.NativeFieldInfoPtr_ScreenshotToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "ScreenshotToggle");
			FeedbackForm.NativeFieldInfoPtr_SaveFileToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "SaveFileToggle");
			FeedbackForm.NativeFieldInfoPtr_SummaryField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "SummaryField");
			FeedbackForm.NativeFieldInfoPtr_DescriptionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "DescriptionField");
			FeedbackForm.NativeFieldInfoPtr_Cog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "Cog");
			FeedbackForm.NativeFieldInfoPtr_CategoryDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "CategoryDropdown");
			FeedbackForm.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681148);
			FeedbackForm.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681149);
			FeedbackForm.NativeMethodInfoPtr_PrepScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681150);
			FeedbackForm.NativeMethodInfoPtr_OnScreenshotToggle_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681151);
			FeedbackForm.NativeMethodInfoPtr_OnSaveFileToggle_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681152);
			FeedbackForm.NativeMethodInfoPtr_SetFormData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681153);
			FeedbackForm.NativeMethodInfoPtr_SetCategory_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681154);
			FeedbackForm.NativeMethodInfoPtr_Submit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681155);
			FeedbackForm.NativeMethodInfoPtr_GetTextToAppendToTitle_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681156);
			FeedbackForm.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681157);
			FeedbackForm.NativeMethodInfoPtr_ScreenshotAndOpenForm_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681158);
			FeedbackForm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681159);
			FeedbackForm.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681160);
			FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_0_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681161);
			FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100681162);
		}

		// Token: 0x06008EFC RID: 36604 RVA: 0x0025742C File Offset: 0x0025562C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260930, XrefRangeEnd = 260957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackForm.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EFD RID: 36605 RVA: 0x00257468 File Offset: 0x00255668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260957, XrefRangeEnd = 260960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EFE RID: 36606 RVA: 0x0025749C File Offset: 0x0025569C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260960, XrefRangeEnd = 260965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_PrepScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EFF RID: 36607 RVA: 0x002574D0 File Offset: 0x002556D0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScreenshotToggle(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_OnScreenshotToggle_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x00257510 File Offset: 0x00255710
		[CallerCount(0)]
		public unsafe void OnSaveFileToggle(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_OnSaveFileToggle_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x00257550 File Offset: 0x00255750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260965, XrefRangeEnd = 260979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFormData(string title)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_SetFormData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x00257594 File Offset: 0x00255794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260979, XrefRangeEnd = 260984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCategory(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_SetCategory_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x002575D8 File Offset: 0x002557D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260984, XrefRangeEnd = 261161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackForm.NativeMethodInfoPtr_Submit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x00257614 File Offset: 0x00255814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261161, XrefRangeEnd = 261186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetTextToAppendToTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackForm.NativeMethodInfoPtr_GetTextToAppendToTitle_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x00257658 File Offset: 0x00255858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261186, XrefRangeEnd = 261192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F06 RID: 36614 RVA: 0x0025768C File Offset: 0x0025588C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261192, XrefRangeEnd = 261197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator ScreenshotAndOpenForm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_ScreenshotAndOpenForm_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008F07 RID: 36615 RVA: 0x002576CC File Offset: 0x002558CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261197, XrefRangeEnd = 261198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeedbackForm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F08 RID: 36616 RVA: 0x00257708 File Offset: 0x00255908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261198, XrefRangeEnd = 261203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008F09 RID: 36617 RVA: 0x00257748 File Offset: 0x00255948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261203, XrefRangeEnd = 261207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScreenshotAndOpenForm_b__18_0(Il2CppStructArray<byte> ss)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ss);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_0_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x0025778C File Offset: 0x0025598C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261207, XrefRangeEnd = 261211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScreenshotAndOpenForm_b__18_1(string err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(err);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x000444EF File Offset: 0x000426EF
		public FeedbackForm(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x06008F0C RID: 36620 RVA: 0x002577D0 File Offset: 0x002559D0
		// (set) Token: 0x06008F0D RID: 36621 RVA: 0x000444F8 File Offset: 0x000426F8
		public new unsafe Coroutine ssCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ssCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ssCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x06008F0E RID: 36622 RVA: 0x00257800 File Offset: 0x00255A00
		// (set) Token: 0x06008F0F RID: 36623 RVA: 0x00044517 File Offset: 0x00042717
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x06008F10 RID: 36624 RVA: 0x00257830 File Offset: 0x00255A30
		// (set) Token: 0x06008F11 RID: 36625 RVA: 0x00044536 File Offset: 0x00042736
		public unsafe Toggle ScreenshotToggle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ScreenshotToggle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ScreenshotToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x06008F12 RID: 36626 RVA: 0x00257860 File Offset: 0x00255A60
		// (set) Token: 0x06008F13 RID: 36627 RVA: 0x00044555 File Offset: 0x00042755
		public unsafe Toggle SaveFileToggle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SaveFileToggle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SaveFileToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x06008F14 RID: 36628 RVA: 0x00257890 File Offset: 0x00255A90
		// (set) Token: 0x06008F15 RID: 36629 RVA: 0x00044574 File Offset: 0x00042774
		public unsafe TMP_InputField SummaryField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SummaryField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SummaryField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x06008F16 RID: 36630 RVA: 0x002578C0 File Offset: 0x00255AC0
		// (set) Token: 0x06008F17 RID: 36631 RVA: 0x00044593 File Offset: 0x00042793
		public unsafe TMP_InputField DescriptionField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_DescriptionField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_DescriptionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x06008F18 RID: 36632 RVA: 0x002578F0 File Offset: 0x00255AF0
		// (set) Token: 0x06008F19 RID: 36633 RVA: 0x000445B2 File Offset: 0x000427B2
		public unsafe RectTransform Cog
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_Cog);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_Cog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x06008F1A RID: 36634 RVA: 0x00257920 File Offset: 0x00255B20
		// (set) Token: 0x06008F1B RID: 36635 RVA: 0x000445D1 File Offset: 0x000427D1
		public unsafe TMP_Dropdown CategoryDropdown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CategoryDropdown);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CategoryDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060ED RID: 24813
		private static readonly System.IntPtr NativeFieldInfoPtr_ssCoroutine;

		// Token: 0x040060EE RID: 24814
		private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x040060EF RID: 24815
		private static readonly System.IntPtr NativeFieldInfoPtr_ScreenshotToggle;

		// Token: 0x040060F0 RID: 24816
		private static readonly System.IntPtr NativeFieldInfoPtr_SaveFileToggle;

		// Token: 0x040060F1 RID: 24817
		private static readonly System.IntPtr NativeFieldInfoPtr_SummaryField;

		// Token: 0x040060F2 RID: 24818
		private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionField;

		// Token: 0x040060F3 RID: 24819
		private static readonly System.IntPtr NativeFieldInfoPtr_Cog;

		// Token: 0x040060F4 RID: 24820
		private static readonly System.IntPtr NativeFieldInfoPtr_CategoryDropdown;

		// Token: 0x040060F5 RID: 24821
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040060F6 RID: 24822
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040060F7 RID: 24823
		private static readonly System.IntPtr NativeMethodInfoPtr_PrepScreenshot_Public_Void_0;

		// Token: 0x040060F8 RID: 24824
		private static readonly System.IntPtr NativeMethodInfoPtr_OnScreenshotToggle_Private_Void_Boolean_0;

		// Token: 0x040060F9 RID: 24825
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSaveFileToggle_Private_Void_Boolean_0;

		// Token: 0x040060FA RID: 24826
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFormData_Public_Void_String_0;

		// Token: 0x040060FB RID: 24827
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCategory_Public_Void_String_0;

		// Token: 0x040060FC RID: 24828
		private static readonly System.IntPtr NativeMethodInfoPtr_Submit_Public_Virtual_Void_0;

		// Token: 0x040060FD RID: 24829
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTextToAppendToTitle_Protected_Virtual_String_0;

		// Token: 0x040060FE RID: 24830
		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x040060FF RID: 24831
		private static readonly System.IntPtr NativeMethodInfoPtr_ScreenshotAndOpenForm_Private_IEnumerator_0;

		// Token: 0x04006100 RID: 24832
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006101 RID: 24833
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006102 RID: 24834
		private static readonly System.IntPtr NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_0_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04006103 RID: 24835
		private static readonly System.IntPtr NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_1_Private_Void_String_0;

		// Token: 0x02000B6C RID: 2924
		[ObfuscatedName("ScheduleOne.UI.FeedbackForm+<<Submit>g__Wait|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DC65 RID: 56421 RVA: 0x00348DD8 File Offset: 0x00346FD8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique()
			{
				Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "<<Submit>g__Wait|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, "<>1__state");
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, "<>2__current");
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, "<>4__this");
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100681163);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100681164);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100681165);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100681166);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100681167);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100681168);
			}

			// Token: 0x0600DC66 RID: 56422 RVA: 0x00348EB8 File Offset: 0x003470B8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC67 RID: 56423 RVA: 0x00348F00 File Offset: 0x00347100
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC68 RID: 56424 RVA: 0x00348F34 File Offset: 0x00347134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260900, XrefRangeEnd = 260906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004400 RID: 17408
			// (get) Token: 0x0600DC69 RID: 56425 RVA: 0x00348F70 File Offset: 0x00347170
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC6A RID: 56426 RVA: 0x00348FB0 File Offset: 0x003471B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260906, XrefRangeEnd = 260911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004401 RID: 17409
			// (get) Token: 0x0600DC6B RID: 56427 RVA: 0x00348FE4 File Offset: 0x003471E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC6C RID: 56428 RVA: 0x0006AF86 File Offset: 0x00069186
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043FD RID: 17405
			// (get) Token: 0x0600DC6D RID: 56429 RVA: 0x00349024 File Offset: 0x00347224
			// (set) Token: 0x0600DC6E RID: 56430 RVA: 0x0006AF8F File Offset: 0x0006918F
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043FE RID: 17406
			// (get) Token: 0x0600DC6F RID: 56431 RVA: 0x0034904C File Offset: 0x0034724C
			// (set) Token: 0x0600DC70 RID: 56432 RVA: 0x0006AFAA File Offset: 0x000691AA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043FF RID: 17407
			// (get) Token: 0x0600DC71 RID: 56433 RVA: 0x0034907C File Offset: 0x0034727C
			// (set) Token: 0x0600DC72 RID: 56434 RVA: 0x0006AFC9 File Offset: 0x000691C9
			public unsafe FeedbackForm __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeedbackForm>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400943F RID: 37951
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009440 RID: 37952
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009441 RID: 37953
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009442 RID: 37954
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009443 RID: 37955
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009444 RID: 37956
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009445 RID: 37957
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009446 RID: 37958
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009447 RID: 37959
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B6D RID: 2925
		[ObfuscatedName("ScheduleOne.UI.FeedbackForm+<ScreenshotAndOpenForm>d__18")]
		public sealed class _ScreenshotAndOpenForm_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600DC73 RID: 56435 RVA: 0x003490AC File Offset: 0x003472AC
			// Note: this type is marked as 'beforefieldinit'.
			static _ScreenshotAndOpenForm_d__18()
			{
				Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "<ScreenshotAndOpenForm>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, "<>1__state");
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, "<>2__current");
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, "<>4__this");
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100681169);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100681170);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100681171);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100681172);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100681173);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100681174);
			}

			// Token: 0x0600DC74 RID: 56436 RVA: 0x0034918C File Offset: 0x0034738C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ScreenshotAndOpenForm_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC75 RID: 56437 RVA: 0x003491D4 File Offset: 0x003473D4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC76 RID: 56438 RVA: 0x00349208 File Offset: 0x00347408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260911, XrefRangeEnd = 260925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004405 RID: 17413
			// (get) Token: 0x0600DC77 RID: 56439 RVA: 0x00349244 File Offset: 0x00347444
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC78 RID: 56440 RVA: 0x00349284 File Offset: 0x00347484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260925, XrefRangeEnd = 260930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004406 RID: 17414
			// (get) Token: 0x0600DC79 RID: 56441 RVA: 0x003492B8 File Offset: 0x003474B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC7A RID: 56442 RVA: 0x0006AFE8 File Offset: 0x000691E8
			public _ScreenshotAndOpenForm_d__18(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004402 RID: 17410
			// (get) Token: 0x0600DC7B RID: 56443 RVA: 0x003492F8 File Offset: 0x003474F8
			// (set) Token: 0x0600DC7C RID: 56444 RVA: 0x0006AFF1 File Offset: 0x000691F1
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004403 RID: 17411
			// (get) Token: 0x0600DC7D RID: 56445 RVA: 0x00349320 File Offset: 0x00347520
			// (set) Token: 0x0600DC7E RID: 56446 RVA: 0x0006B00C File Offset: 0x0006920C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004404 RID: 17412
			// (get) Token: 0x0600DC7F RID: 56447 RVA: 0x00349350 File Offset: 0x00347550
			// (set) Token: 0x0600DC80 RID: 56448 RVA: 0x0006B02B File Offset: 0x0006922B
			public unsafe FeedbackForm __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeedbackForm>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009448 RID: 37960
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009449 RID: 37961
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400944A RID: 37962
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400944B RID: 37963
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400944C RID: 37964
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400944D RID: 37965
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400944E RID: 37966
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400944F RID: 37967
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009450 RID: 37968
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
