using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066E RID: 1646
	public class MouseTooltip : Singleton<MouseTooltip>
	{
		// Token: 0x06009103 RID: 37123 RVA: 0x0025D104 File Offset: 0x0025B304
		// Note: this type is marked as 'beforefieldinit'.
		static MouseTooltip()
		{
			Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "MouseTooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr);
			MouseTooltip.NativeFieldInfoPtr_IconRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconRect");
			MouseTooltip.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconImg");
			MouseTooltip.NativeFieldInfoPtr_TooltipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipRect");
			MouseTooltip.NativeFieldInfoPtr_TooltipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipLabel");
			MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipOffset_NoIcon");
			MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "TooltipOffset_WithIcon");
			MouseTooltip.NativeFieldInfoPtr_IconOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "IconOffset");
			MouseTooltip.NativeFieldInfoPtr_Color_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "Color_Invalid");
			MouseTooltip.NativeFieldInfoPtr_Sprite_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "Sprite_Cross");
			MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "tooltipShownThisFrame");
			MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, "iconShownThisFrame");
			MouseTooltip.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681396);
			MouseTooltip.NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681397);
			MouseTooltip.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681398);
			MouseTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr, 100681399);
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x0025D260 File Offset: 0x0025B460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263501, RefRangeEnd = 263502, XrefRangeStart = 263501, XrefRangeEnd = 263501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTooltip(string text, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x0025D2B0 File Offset: 0x0025B4B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263503, RefRangeEnd = 263504, XrefRangeStart = 263502, XrefRangeEnd = 263503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowIcon(Sprite sprite, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x0025D300 File Offset: 0x0025B500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263504, XrefRangeEnd = 263514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x0025D334 File Offset: 0x0025B534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263514, XrefRangeEnd = 263517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseTooltip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseTooltip>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x00045874 File Offset: 0x00043A74
		public MouseTooltip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x06009109 RID: 37129 RVA: 0x0025D370 File Offset: 0x0025B570
		// (set) Token: 0x0600910A RID: 37130 RVA: 0x0004587D File Offset: 0x00043A7D
		public unsafe RectTransform IconRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x0600910B RID: 37131 RVA: 0x0025D3A0 File Offset: 0x0025B5A0
		// (set) Token: 0x0600910C RID: 37132 RVA: 0x0004589C File Offset: 0x00043A9C
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x0600910D RID: 37133 RVA: 0x0025D3D0 File Offset: 0x0025B5D0
		// (set) Token: 0x0600910E RID: 37134 RVA: 0x000458BB File Offset: 0x00043ABB
		public unsafe RectTransform TooltipRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x0600910F RID: 37135 RVA: 0x0025D400 File Offset: 0x0025B600
		// (set) Token: 0x06009110 RID: 37136 RVA: 0x000458DA File Offset: 0x00043ADA
		public unsafe TextMeshProUGUI TooltipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x06009111 RID: 37137 RVA: 0x0025D430 File Offset: 0x0025B630
		// (set) Token: 0x06009112 RID: 37138 RVA: 0x000458F9 File Offset: 0x00043AF9
		public unsafe Vector3 TooltipOffset_NoIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_NoIcon)) = value;
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x06009113 RID: 37139 RVA: 0x0025D458 File Offset: 0x0025B658
		// (set) Token: 0x06009114 RID: 37140 RVA: 0x00045914 File Offset: 0x00043B14
		public unsafe Vector3 TooltipOffset_WithIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_TooltipOffset_WithIcon)) = value;
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x06009115 RID: 37141 RVA: 0x0025D480 File Offset: 0x0025B680
		// (set) Token: 0x06009116 RID: 37142 RVA: 0x0004592F File Offset: 0x00043B2F
		public unsafe Vector3 IconOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_IconOffset)) = value;
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x06009117 RID: 37143 RVA: 0x0025D4A8 File Offset: 0x0025B6A8
		// (set) Token: 0x06009118 RID: 37144 RVA: 0x0004594A File Offset: 0x00043B4A
		public unsafe Color Color_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Color_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Color_Invalid)) = value;
			}
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x06009119 RID: 37145 RVA: 0x0025D4D0 File Offset: 0x0025B6D0
		// (set) Token: 0x0600911A RID: 37146 RVA: 0x00045965 File Offset: 0x00043B65
		public unsafe Sprite Sprite_Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Sprite_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_Sprite_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x0600911B RID: 37147 RVA: 0x0025D500 File Offset: 0x0025B700
		// (set) Token: 0x0600911C RID: 37148 RVA: 0x00045984 File Offset: 0x00043B84
		public unsafe bool tooltipShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_tooltipShownThisFrame)) = value;
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x0600911D RID: 37149 RVA: 0x0025D528 File Offset: 0x0025B728
		// (set) Token: 0x0600911E RID: 37150 RVA: 0x0004599F File Offset: 0x00043B9F
		public unsafe bool iconShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseTooltip.NativeFieldInfoPtr_iconShownThisFrame)) = value;
			}
		}

		// Token: 0x04006230 RID: 25136
		private static readonly IntPtr NativeFieldInfoPtr_IconRect;

		// Token: 0x04006231 RID: 25137
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04006232 RID: 25138
		private static readonly IntPtr NativeFieldInfoPtr_TooltipRect;

		// Token: 0x04006233 RID: 25139
		private static readonly IntPtr NativeFieldInfoPtr_TooltipLabel;

		// Token: 0x04006234 RID: 25140
		private static readonly IntPtr NativeFieldInfoPtr_TooltipOffset_NoIcon;

		// Token: 0x04006235 RID: 25141
		private static readonly IntPtr NativeFieldInfoPtr_TooltipOffset_WithIcon;

		// Token: 0x04006236 RID: 25142
		private static readonly IntPtr NativeFieldInfoPtr_IconOffset;

		// Token: 0x04006237 RID: 25143
		private static readonly IntPtr NativeFieldInfoPtr_Color_Invalid;

		// Token: 0x04006238 RID: 25144
		private static readonly IntPtr NativeFieldInfoPtr_Sprite_Cross;

		// Token: 0x04006239 RID: 25145
		private static readonly IntPtr NativeFieldInfoPtr_tooltipShownThisFrame;

		// Token: 0x0400623A RID: 25146
		private static readonly IntPtr NativeFieldInfoPtr_iconShownThisFrame;

		// Token: 0x0400623B RID: 25147
		private static readonly IntPtr NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Color_0;

		// Token: 0x0400623C RID: 25148
		private static readonly IntPtr NativeMethodInfoPtr_ShowIcon_Public_Void_Sprite_Color_0;

		// Token: 0x0400623D RID: 25149
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400623E RID: 25150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
