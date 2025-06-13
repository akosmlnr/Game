using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065B RID: 1627
	public class DocumentViewer : Singleton<DocumentViewer>
	{
		// Token: 0x06008EE2 RID: 36578 RVA: 0x00256D28 File Offset: 0x00254F28
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentViewer()
		{
			Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DocumentViewer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr);
			DocumentViewer.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "<IsOpen>k__BackingField");
			DocumentViewer.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "Canvas");
			DocumentViewer.NativeFieldInfoPtr_Documents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "Documents");
			DocumentViewer.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "onOpen");
			DocumentViewer.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100681137);
			DocumentViewer.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100681138);
			DocumentViewer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100681139);
			DocumentViewer.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100681140);
			DocumentViewer.NativeMethodInfoPtr_Open_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100681141);
			DocumentViewer.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100681142);
			DocumentViewer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100681143);
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x06008EE3 RID: 36579 RVA: 0x00256E34 File Offset: 0x00255034
		// (set) Token: 0x06008EE4 RID: 36580 RVA: 0x00256E70 File Offset: 0x00255070
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008EE5 RID: 36581 RVA: 0x00256EB0 File Offset: 0x002550B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260771, XrefRangeEnd = 260786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DocumentViewer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EE6 RID: 36582 RVA: 0x00256EEC File Offset: 0x002550EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260786, XrefRangeEnd = 260788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EE7 RID: 36583 RVA: 0x00256F30 File Offset: 0x00255130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260834, RefRangeEnd = 260835, XrefRangeStart = 260788, XrefRangeEnd = 260834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string documentName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(documentName);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_Open_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EE8 RID: 36584 RVA: 0x00256F74 File Offset: 0x00255174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260874, RefRangeEnd = 260875, XrefRangeStart = 260835, XrefRangeEnd = 260874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x00256FA8 File Offset: 0x002551A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260875, XrefRangeEnd = 260878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DocumentViewer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x0004444A File Offset: 0x0004264A
		public DocumentViewer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x06008EEB RID: 36587 RVA: 0x00256FE4 File Offset: 0x002551E4
		// (set) Token: 0x06008EEC RID: 36588 RVA: 0x00044453 File Offset: 0x00042653
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x06008EED RID: 36589 RVA: 0x0025700C File Offset: 0x0025520C
		// (set) Token: 0x06008EEE RID: 36590 RVA: 0x0004446E File Offset: 0x0004266E
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x06008EEF RID: 36591 RVA: 0x0025703C File Offset: 0x0025523C
		// (set) Token: 0x06008EF0 RID: 36592 RVA: 0x0004448D File Offset: 0x0004268D
		public unsafe Il2CppReferenceArray<RectTransform> Documents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Documents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Documents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x06008EF1 RID: 36593 RVA: 0x0025706C File Offset: 0x0025526C
		// (set) Token: 0x06008EF2 RID: 36594 RVA: 0x000444AC File Offset: 0x000426AC
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060DD RID: 24797
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040060DE RID: 24798
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040060DF RID: 24799
		private static readonly IntPtr NativeFieldInfoPtr_Documents;

		// Token: 0x040060E0 RID: 24800
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x040060E1 RID: 24801
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040060E2 RID: 24802
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040060E3 RID: 24803
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040060E4 RID: 24804
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040060E5 RID: 24805
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_0;

		// Token: 0x040060E6 RID: 24806
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040060E7 RID: 24807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
