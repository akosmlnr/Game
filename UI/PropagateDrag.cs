using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000684 RID: 1668
	public class PropagateDrag : MonoBehaviour
	{
		// Token: 0x06009402 RID: 37890 RVA: 0x00265BBC File Offset: 0x00263DBC
		// Note: this type is marked as 'beforefieldinit'.
		static PropagateDrag()
		{
			Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropagateDrag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr);
			PropagateDrag.NativeFieldInfoPtr_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, "ScrollView");
			PropagateDrag.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681737);
			PropagateDrag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681738);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681739);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681740);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681741);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681742);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681743);
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x00265C8C File Offset: 0x00263E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267350, XrefRangeEnd = 267433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x00265CC0 File Offset: 0x00263EC0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropagateDrag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x00265CFC File Offset: 0x00263EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267433, XrefRangeEnd = 267437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x00265D40 File Offset: 0x00263F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267437, XrefRangeEnd = 267441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x00265D84 File Offset: 0x00263F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267441, XrefRangeEnd = 267445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_2(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x00265DC8 File Offset: 0x00263FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267445, XrefRangeEnd = 267449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_3(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x00265E0C File Offset: 0x0026400C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267449, XrefRangeEnd = 267453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_4(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x00047504 File Offset: 0x00045704
		public PropagateDrag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x0600940B RID: 37899 RVA: 0x00265E50 File Offset: 0x00264050
		// (set) Token: 0x0600940C RID: 37900 RVA: 0x0004750D File Offset: 0x0004570D
		public unsafe ScrollRect ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagateDrag.NativeFieldInfoPtr_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagateDrag.NativeFieldInfoPtr_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400640B RID: 25611
		private static readonly IntPtr NativeFieldInfoPtr_ScrollView;

		// Token: 0x0400640C RID: 25612
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400640D RID: 25613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400640E RID: 25614
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0;

		// Token: 0x0400640F RID: 25615
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0;

		// Token: 0x04006410 RID: 25616
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0;

		// Token: 0x04006411 RID: 25617
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0;

		// Token: 0x04006412 RID: 25618
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0;
	}
}
