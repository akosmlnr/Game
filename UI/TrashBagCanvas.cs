using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000695 RID: 1685
	public class TrashBagCanvas : Singleton<TrashBagCanvas>
	{
		// Token: 0x06009564 RID: 38244 RVA: 0x00269E78 File Offset: 0x00268078
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBagCanvas()
		{
			Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TrashBagCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr);
			TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "<IsOpen>k__BackingField");
			TrashBagCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "Canvas");
			TrashBagCanvas.NativeFieldInfoPtr_InputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, "InputPrompt");
			TrashBagCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681914);
			TrashBagCanvas.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681915);
			TrashBagCanvas.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681916);
			TrashBagCanvas.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681917);
			TrashBagCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr, 100681918);
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x06009565 RID: 38245 RVA: 0x00269F48 File Offset: 0x00268148
		// (set) Token: 0x06009566 RID: 38246 RVA: 0x00269F84 File Offset: 0x00268184
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x00269FC4 File Offset: 0x002681C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269006, RefRangeEnd = 269007, XrefRangeStart = 269004, XrefRangeEnd = 269006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x00269FF8 File Offset: 0x002681F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269009, RefRangeEnd = 269010, XrefRangeStart = 269007, XrefRangeEnd = 269009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x0026A02C File Offset: 0x0026822C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269010, XrefRangeEnd = 269013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBagCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBagCanvas>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x0004816C File Offset: 0x0004636C
		public TrashBagCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x0600956B RID: 38251 RVA: 0x0026A068 File Offset: 0x00268268
		// (set) Token: 0x0600956C RID: 38252 RVA: 0x00048175 File Offset: 0x00046375
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0600956D RID: 38253 RVA: 0x0026A090 File Offset: 0x00268290
		// (set) Token: 0x0600956E RID: 38254 RVA: 0x00048190 File Offset: 0x00046390
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x0600956F RID: 38255 RVA: 0x0026A0C0 File Offset: 0x002682C0
		// (set) Token: 0x06009570 RID: 38256 RVA: 0x000481AF File Offset: 0x000463AF
		public unsafe InputPrompt InputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_InputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBagCanvas.NativeFieldInfoPtr_InputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064E6 RID: 25830
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040064E7 RID: 25831
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040064E8 RID: 25832
		private static readonly IntPtr NativeFieldInfoPtr_InputPrompt;

		// Token: 0x040064E9 RID: 25833
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040064EA RID: 25834
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040064EB RID: 25835
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040064EC RID: 25836
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040064ED RID: 25837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
