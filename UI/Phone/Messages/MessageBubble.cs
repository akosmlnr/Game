using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006D5 RID: 1749
	public class MessageBubble : MonoBehaviour
	{
		// Token: 0x06009C67 RID: 40039 RVA: 0x0027F054 File Offset: 0x0027D254
		// Note: this type is marked as 'beforefieldinit'.
		static MessageBubble()
		{
			Il2CppClassPointerStore<MessageBubble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageBubble");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr);
			MessageBubble.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "text");
			MessageBubble.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "alignment");
			MessageBubble.NativeFieldInfoPtr_showTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "showTriangle");
			MessageBubble.NativeFieldInfoPtr_bubble_MinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble_MinWidth");
			MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble_MaxWidth");
			MessageBubble.NativeFieldInfoPtr_alignTextCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "alignTextCenter");
			MessageBubble.NativeFieldInfoPtr_autosetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "autosetPosition");
			MessageBubble.NativeFieldInfoPtr_displayedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "displayedText");
			MessageBubble.NativeFieldInfoPtr_triangleShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangleShown");
			MessageBubble.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "container");
			MessageBubble.NativeFieldInfoPtr_bubble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble");
			MessageBubble.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "content");
			MessageBubble.NativeFieldInfoPtr_triangle_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangle_Left");
			MessageBubble.NativeFieldInfoPtr_triangle_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangle_Right");
			MessageBubble.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "button");
			MessageBubble.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "height");
			MessageBubble.NativeFieldInfoPtr_spacingAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "spacingAbove");
			MessageBubble.NativeFieldInfoPtr_backgroundColor_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "backgroundColor_Left");
			MessageBubble.NativeFieldInfoPtr_textColor_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "textColor_Left");
			MessageBubble.NativeFieldInfoPtr_backgroundColor_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "backgroundColor_Right");
			MessageBubble.NativeFieldInfoPtr_textColor_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "textColor_Right");
			MessageBubble.NativeFieldInfoPtr_baseBubbleSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "baseBubbleSpacing");
			MessageBubble.NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682672);
			MessageBubble.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682673);
			MessageBubble.NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682674);
			MessageBubble.NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682675);
			MessageBubble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682676);
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x0027F2A0 File Offset: 0x0027D4A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278647, RefRangeEnd = 278650, XrefRangeStart = 278623, XrefRangeEnd = 278647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupBubble(string _text, MessageBubble.Alignment _alignment, bool alignCenter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignCenter;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x0027F300 File Offset: 0x0027D500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278650, XrefRangeEnd = 278651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C6A RID: 40042 RVA: 0x0027F33C File Offset: 0x0027D53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278651, XrefRangeEnd = 278664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshDisplayedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C6B RID: 40043 RVA: 0x0027F378 File Offset: 0x0027D578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278664, XrefRangeEnd = 278673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshTriangle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C6C RID: 40044 RVA: 0x0027F3B4 File Offset: 0x0027D5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278673, XrefRangeEnd = 278679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageBubble() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C6D RID: 40045 RVA: 0x0004C1BE File Offset: 0x0004A3BE
		public MessageBubble(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x06009C6E RID: 40046 RVA: 0x0027F3F0 File Offset: 0x0027D5F0
		// (set) Token: 0x06009C6F RID: 40047 RVA: 0x0004C1C7 File Offset: 0x0004A3C7
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x06009C70 RID: 40048 RVA: 0x0027F418 File Offset: 0x0027D618
		// (set) Token: 0x06009C71 RID: 40049 RVA: 0x0004C1E6 File Offset: 0x0004A3E6
		public unsafe MessageBubble.Alignment alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x06009C72 RID: 40050 RVA: 0x0027F440 File Offset: 0x0027D640
		// (set) Token: 0x06009C73 RID: 40051 RVA: 0x0004C201 File Offset: 0x0004A401
		public unsafe bool showTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_showTriangle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_showTriangle)) = value;
			}
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x06009C74 RID: 40052 RVA: 0x0027F468 File Offset: 0x0027D668
		// (set) Token: 0x06009C75 RID: 40053 RVA: 0x0004C21C File Offset: 0x0004A41C
		public unsafe float bubble_MinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MinWidth)) = value;
			}
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x06009C76 RID: 40054 RVA: 0x0027F490 File Offset: 0x0027D690
		// (set) Token: 0x06009C77 RID: 40055 RVA: 0x0004C237 File Offset: 0x0004A437
		public unsafe float bubble_MaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth)) = value;
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x06009C78 RID: 40056 RVA: 0x0027F4B8 File Offset: 0x0027D6B8
		// (set) Token: 0x06009C79 RID: 40057 RVA: 0x0004C252 File Offset: 0x0004A452
		public unsafe bool alignTextCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignTextCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignTextCenter)) = value;
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x06009C7A RID: 40058 RVA: 0x0027F4E0 File Offset: 0x0027D6E0
		// (set) Token: 0x06009C7B RID: 40059 RVA: 0x0004C26D File Offset: 0x0004A46D
		public unsafe bool autosetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_autosetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_autosetPosition)) = value;
			}
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x06009C7C RID: 40060 RVA: 0x0027F508 File Offset: 0x0027D708
		// (set) Token: 0x06009C7D RID: 40061 RVA: 0x0004C288 File Offset: 0x0004A488
		public unsafe string displayedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_displayedText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_displayedText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x06009C7E RID: 40062 RVA: 0x0027F530 File Offset: 0x0027D730
		// (set) Token: 0x06009C7F RID: 40063 RVA: 0x0004C2A7 File Offset: 0x0004A4A7
		public unsafe bool triangleShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangleShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangleShown)) = value;
			}
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x06009C80 RID: 40064 RVA: 0x0027F558 File Offset: 0x0027D758
		// (set) Token: 0x06009C81 RID: 40065 RVA: 0x0004C2C2 File Offset: 0x0004A4C2
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x06009C82 RID: 40066 RVA: 0x0027F588 File Offset: 0x0027D788
		// (set) Token: 0x06009C83 RID: 40067 RVA: 0x0004C2E1 File Offset: 0x0004A4E1
		public unsafe Image bubble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x06009C84 RID: 40068 RVA: 0x0027F5B8 File Offset: 0x0027D7B8
		// (set) Token: 0x06009C85 RID: 40069 RVA: 0x0004C300 File Offset: 0x0004A500
		public unsafe Text content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x06009C86 RID: 40070 RVA: 0x0027F5E8 File Offset: 0x0027D7E8
		// (set) Token: 0x06009C87 RID: 40071 RVA: 0x0004C31F File Offset: 0x0004A51F
		public unsafe Image triangle_Left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x06009C88 RID: 40072 RVA: 0x0027F618 File Offset: 0x0027D818
		// (set) Token: 0x06009C89 RID: 40073 RVA: 0x0004C33E File Offset: 0x0004A53E
		public unsafe Image triangle_Right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x06009C8A RID: 40074 RVA: 0x0027F648 File Offset: 0x0027D848
		// (set) Token: 0x06009C8B RID: 40075 RVA: 0x0004C35D File Offset: 0x0004A55D
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF2 RID: 12274
		// (get) Token: 0x06009C8C RID: 40076 RVA: 0x0027F678 File Offset: 0x0027D878
		// (set) Token: 0x06009C8D RID: 40077 RVA: 0x0004C37C File Offset: 0x0004A57C
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x17002FF3 RID: 12275
		// (get) Token: 0x06009C8E RID: 40078 RVA: 0x0027F6A0 File Offset: 0x0027D8A0
		// (set) Token: 0x06009C8F RID: 40079 RVA: 0x0004C397 File Offset: 0x0004A597
		public unsafe float spacingAbove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_spacingAbove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_spacingAbove)) = value;
			}
		}

		// Token: 0x17002FF4 RID: 12276
		// (get) Token: 0x06009C90 RID: 40080 RVA: 0x0027F6C8 File Offset: 0x0027D8C8
		// (set) Token: 0x06009C91 RID: 40081 RVA: 0x0004C3B2 File Offset: 0x0004A5B2
		public unsafe static Color32 backgroundColor_Left
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Left, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Left, (void*)(&value));
			}
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x06009C92 RID: 40082 RVA: 0x0027F6E4 File Offset: 0x0027D8E4
		// (set) Token: 0x06009C93 RID: 40083 RVA: 0x0004C3C0 File Offset: 0x0004A5C0
		public unsafe static Color32 textColor_Left
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_textColor_Left, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_textColor_Left, (void*)(&value));
			}
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x06009C94 RID: 40084 RVA: 0x0027F700 File Offset: 0x0027D900
		// (set) Token: 0x06009C95 RID: 40085 RVA: 0x0004C3CE File Offset: 0x0004A5CE
		public unsafe static Color32 backgroundColor_Right
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Right, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Right, (void*)(&value));
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x06009C96 RID: 40086 RVA: 0x0027F71C File Offset: 0x0027D91C
		// (set) Token: 0x06009C97 RID: 40087 RVA: 0x0004C3DC File Offset: 0x0004A5DC
		public unsafe static Color32 textColor_Right
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_textColor_Right, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_textColor_Right, (void*)(&value));
			}
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x06009C98 RID: 40088 RVA: 0x0027F738 File Offset: 0x0027D938
		// (set) Token: 0x06009C99 RID: 40089 RVA: 0x0004C3EA File Offset: 0x0004A5EA
		public unsafe static float baseBubbleSpacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_baseBubbleSpacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_baseBubbleSpacing, (void*)(&value));
			}
		}

		// Token: 0x0400694A RID: 26954
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400694B RID: 26955
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x0400694C RID: 26956
		private static readonly IntPtr NativeFieldInfoPtr_showTriangle;

		// Token: 0x0400694D RID: 26957
		private static readonly IntPtr NativeFieldInfoPtr_bubble_MinWidth;

		// Token: 0x0400694E RID: 26958
		private static readonly IntPtr NativeFieldInfoPtr_bubble_MaxWidth;

		// Token: 0x0400694F RID: 26959
		private static readonly IntPtr NativeFieldInfoPtr_alignTextCenter;

		// Token: 0x04006950 RID: 26960
		private static readonly IntPtr NativeFieldInfoPtr_autosetPosition;

		// Token: 0x04006951 RID: 26961
		private static readonly IntPtr NativeFieldInfoPtr_displayedText;

		// Token: 0x04006952 RID: 26962
		private static readonly IntPtr NativeFieldInfoPtr_triangleShown;

		// Token: 0x04006953 RID: 26963
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04006954 RID: 26964
		private static readonly IntPtr NativeFieldInfoPtr_bubble;

		// Token: 0x04006955 RID: 26965
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04006956 RID: 26966
		private static readonly IntPtr NativeFieldInfoPtr_triangle_Left;

		// Token: 0x04006957 RID: 26967
		private static readonly IntPtr NativeFieldInfoPtr_triangle_Right;

		// Token: 0x04006958 RID: 26968
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04006959 RID: 26969
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400695A RID: 26970
		private static readonly IntPtr NativeFieldInfoPtr_spacingAbove;

		// Token: 0x0400695B RID: 26971
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColor_Left;

		// Token: 0x0400695C RID: 26972
		private static readonly IntPtr NativeFieldInfoPtr_textColor_Left;

		// Token: 0x0400695D RID: 26973
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColor_Right;

		// Token: 0x0400695E RID: 26974
		private static readonly IntPtr NativeFieldInfoPtr_textColor_Right;

		// Token: 0x0400695F RID: 26975
		private static readonly IntPtr NativeFieldInfoPtr_baseBubbleSpacing;

		// Token: 0x04006960 RID: 26976
		private static readonly IntPtr NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_0;

		// Token: 0x04006961 RID: 26977
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006962 RID: 26978
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0;

		// Token: 0x04006963 RID: 26979
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0;

		// Token: 0x04006964 RID: 26980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BCD RID: 3021
		[OriginalName("Assembly-CSharp.dll", "", "Alignment")]
		public enum Alignment
		{
			// Token: 0x040096B7 RID: 38583
			Center,
			// Token: 0x040096B8 RID: 38584
			Left,
			// Token: 0x040096B9 RID: 38585
			Right
		}
	}
}
