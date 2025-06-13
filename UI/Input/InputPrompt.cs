using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000717 RID: 1815
	public class InputPrompt : MonoBehaviour
	{
		// Token: 0x0600A174 RID: 41332 RVA: 0x0028E47C File Offset: 0x0028C67C
		// Note: this type is marked as 'beforefieldinit'.
		static InputPrompt()
		{
			Il2CppClassPointerStore<InputPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr);
			InputPrompt.NativeFieldInfoPtr_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Spacing");
			InputPrompt.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Actions");
			InputPrompt.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Label");
			InputPrompt.NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Alignment");
			InputPrompt.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Container");
			InputPrompt.NativeFieldInfoPtr_ImagesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "ImagesContainer");
			InputPrompt.NativeFieldInfoPtr_LabelComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "LabelComponent");
			InputPrompt.NativeFieldInfoPtr_Shade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Shade");
			InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "OverridePromptImageColor");
			InputPrompt.NativeFieldInfoPtr_PromptImageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "PromptImageColor");
			InputPrompt.NativeFieldInfoPtr_promptImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "promptImages");
			InputPrompt.NativeFieldInfoPtr_displayedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "displayedActions");
			InputPrompt.NativeFieldInfoPtr_AppliedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "AppliedAlignment");
			InputPrompt.NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100683199);
			InputPrompt.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100683200);
			InputPrompt.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100683201);
			InputPrompt.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100683202);
			InputPrompt.NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100683203);
			InputPrompt.NativeMethodInfoPtr_SetLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100683204);
			InputPrompt.NativeMethodInfoPtr_UpdateShade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100683205);
			InputPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100683206);
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0600A175 RID: 41333 RVA: 0x0028E650 File Offset: 0x0028C850
		public unsafe InputPromptsManager manager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285289, XrefRangeEnd = 285298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsManager>(intPtr2) : null;
			}
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x0028E690 File Offset: 0x0028C890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285298, XrefRangeEnd = 285302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A177 RID: 41335 RVA: 0x0028E6C4 File Offset: 0x0028C8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285302, XrefRangeEnd = 285305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x0028E6F8 File Offset: 0x0028C8F8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x0028E72C File Offset: 0x0028C92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285403, RefRangeEnd = 285404, XrefRangeStart = 285305, XrefRangeEnd = 285403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPromptImages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A17A RID: 41338 RVA: 0x0028E760 File Offset: 0x0028C960
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 285407, RefRangeEnd = 285414, XrefRangeStart = 285404, XrefRangeEnd = 285407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabel(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_SetLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A17B RID: 41339 RVA: 0x0028E7A4 File Offset: 0x0028C9A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285417, RefRangeEnd = 285420, XrefRangeStart = 285414, XrefRangeEnd = 285417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_UpdateShade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x0028E7D8 File Offset: 0x0028C9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285420, XrefRangeEnd = 285440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPrompt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x0004EF62 File Offset: 0x0004D162
		public InputPrompt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600A17E RID: 41342 RVA: 0x0028E814 File Offset: 0x0028CA14
		// (set) Token: 0x0600A17F RID: 41343 RVA: 0x0004EF6B File Offset: 0x0004D16B
		public unsafe static float Spacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InputPrompt.NativeFieldInfoPtr_Spacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputPrompt.NativeFieldInfoPtr_Spacing, (void*)(&value));
			}
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0600A180 RID: 41344 RVA: 0x0028E830 File Offset: 0x0028CA30
		// (set) Token: 0x0600A181 RID: 41345 RVA: 0x0004EF79 File Offset: 0x0004D179
		public unsafe List<InputActionReference> Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0600A182 RID: 41346 RVA: 0x0028E860 File Offset: 0x0028CA60
		// (set) Token: 0x0600A183 RID: 41347 RVA: 0x0004EF98 File Offset: 0x0004D198
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0600A184 RID: 41348 RVA: 0x0028E888 File Offset: 0x0028CA88
		// (set) Token: 0x0600A185 RID: 41349 RVA: 0x0004EFB7 File Offset: 0x0004D1B7
		public unsafe InputPrompt.EInputPromptAlignment Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Alignment)) = value;
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0600A186 RID: 41350 RVA: 0x0028E8B0 File Offset: 0x0028CAB0
		// (set) Token: 0x0600A187 RID: 41351 RVA: 0x0004EFD2 File Offset: 0x0004D1D2
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0600A188 RID: 41352 RVA: 0x0028E8E0 File Offset: 0x0028CAE0
		// (set) Token: 0x0600A189 RID: 41353 RVA: 0x0004EFF1 File Offset: 0x0004D1F1
		public unsafe RectTransform ImagesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_ImagesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_ImagesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0600A18A RID: 41354 RVA: 0x0028E910 File Offset: 0x0028CB10
		// (set) Token: 0x0600A18B RID: 41355 RVA: 0x0004F010 File Offset: 0x0004D210
		public unsafe TextMeshProUGUI LabelComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_LabelComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_LabelComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0600A18C RID: 41356 RVA: 0x0028E940 File Offset: 0x0028CB40
		// (set) Token: 0x0600A18D RID: 41357 RVA: 0x0004F02F File Offset: 0x0004D22F
		public unsafe RectTransform Shade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Shade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Shade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0600A18E RID: 41358 RVA: 0x0028E970 File Offset: 0x0028CB70
		// (set) Token: 0x0600A18F RID: 41359 RVA: 0x0004F04E File Offset: 0x0004D24E
		public unsafe bool OverridePromptImageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor)) = value;
			}
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0600A190 RID: 41360 RVA: 0x0028E998 File Offset: 0x0028CB98
		// (set) Token: 0x0600A191 RID: 41361 RVA: 0x0004F069 File Offset: 0x0004D269
		public unsafe Color PromptImageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_PromptImageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_PromptImageColor)) = value;
			}
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0600A192 RID: 41362 RVA: 0x0028E9C0 File Offset: 0x0028CBC0
		// (set) Token: 0x0600A193 RID: 41363 RVA: 0x0004F084 File Offset: 0x0004D284
		public unsafe List<PromptImage> promptImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_promptImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PromptImage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_promptImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0600A194 RID: 41364 RVA: 0x0028E9F0 File Offset: 0x0028CBF0
		// (set) Token: 0x0600A195 RID: 41365 RVA: 0x0004F0A3 File Offset: 0x0004D2A3
		public unsafe List<InputActionReference> displayedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_displayedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_displayedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0600A196 RID: 41366 RVA: 0x0028EA20 File Offset: 0x0028CC20
		// (set) Token: 0x0600A197 RID: 41367 RVA: 0x0004F0C2 File Offset: 0x0004D2C2
		public unsafe InputPrompt.EInputPromptAlignment AppliedAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_AppliedAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_AppliedAlignment)) = value;
			}
		}

		// Token: 0x04006C5C RID: 27740
		private static readonly IntPtr NativeFieldInfoPtr_Spacing;

		// Token: 0x04006C5D RID: 27741
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x04006C5E RID: 27742
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006C5F RID: 27743
		private static readonly IntPtr NativeFieldInfoPtr_Alignment;

		// Token: 0x04006C60 RID: 27744
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006C61 RID: 27745
		private static readonly IntPtr NativeFieldInfoPtr_ImagesContainer;

		// Token: 0x04006C62 RID: 27746
		private static readonly IntPtr NativeFieldInfoPtr_LabelComponent;

		// Token: 0x04006C63 RID: 27747
		private static readonly IntPtr NativeFieldInfoPtr_Shade;

		// Token: 0x04006C64 RID: 27748
		private static readonly IntPtr NativeFieldInfoPtr_OverridePromptImageColor;

		// Token: 0x04006C65 RID: 27749
		private static readonly IntPtr NativeFieldInfoPtr_PromptImageColor;

		// Token: 0x04006C66 RID: 27750
		private static readonly IntPtr NativeFieldInfoPtr_promptImages;

		// Token: 0x04006C67 RID: 27751
		private static readonly IntPtr NativeFieldInfoPtr_displayedActions;

		// Token: 0x04006C68 RID: 27752
		private static readonly IntPtr NativeFieldInfoPtr_AppliedAlignment;

		// Token: 0x04006C69 RID: 27753
		private static readonly IntPtr NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0;

		// Token: 0x04006C6A RID: 27754
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04006C6B RID: 27755
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04006C6C RID: 27756
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006C6D RID: 27757
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0;

		// Token: 0x04006C6E RID: 27758
		private static readonly IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_String_0;

		// Token: 0x04006C6F RID: 27759
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShade_Private_Void_0;

		// Token: 0x04006C70 RID: 27760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BF1 RID: 3057
		[OriginalName("Assembly-CSharp.dll", "", "EInputPromptAlignment")]
		public enum EInputPromptAlignment
		{
			// Token: 0x04009759 RID: 38745
			Left,
			// Token: 0x0400975A RID: 38746
			Middle,
			// Token: 0x0400975B RID: 38747
			Right
		}
	}
}
