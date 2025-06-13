using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200048C RID: 1164
	public class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		// Token: 0x060063D5 RID: 25557 RVA: 0x001C85B0 File Offset: 0x001C67B0
		// Note: this type is marked as 'beforefieldinit'.
		static Singleton()
		{
			Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Singleton`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr);
			Singleton<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "instance");
			Singleton<T>.NativeFieldInfoPtr_Destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "Destroyed");
			Singleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100676064);
			Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100676065);
			Singleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100676066);
			Singleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100676067);
			Singleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100676068);
			Singleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100676069);
			Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100676070);
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x001C86D0 File Offset: 0x001C68D0
		public unsafe static bool InstanceExists
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 205928, RefRangeEnd = 205986, XrefRangeStart = 205922, XrefRangeEnd = 205928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x060063D7 RID: 25559 RVA: 0x001C8700 File Offset: 0x001C6900
		// (set) Token: 0x060063D8 RID: 25560 RVA: 0x001C8730 File Offset: 0x001C6930
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
			}
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 204410, RefRangeEnd = 204648, XrefRangeStart = 204410, XrefRangeEnd = 204648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				ref System.IntPtr ptr2 = ref *ptr;
				System.IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				System.IntPtr returnedException;
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x001C879C File Offset: 0x001C699C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Singleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x001C87D8 File Offset: 0x001C69D8
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 206016, RefRangeEnd = 206078, XrefRangeStart = 205986, XrefRangeEnd = 206016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Singleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x001C8814 File Offset: 0x001C6A14
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 206084, RefRangeEnd = 206090, XrefRangeStart = 206078, XrefRangeEnd = 206084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Singleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x001C8850 File Offset: 0x001C6A50
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Singleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x0002EF50 File Offset: 0x0002D150
		public Singleton(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x001C888C File Offset: 0x001C6A8C
		// (set) Token: 0x060063DF RID: 25567 RVA: 0x001C88B0 File Offset: 0x001C6AB0
		public unsafe static T instance
		{
			get
			{
				System.IntPtr objectPointer;
				IL2CPP.il2cpp_field_static_get_value(Singleton<T>.NativeFieldInfoPtr_instance, (void*)(&objectPointer));
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
			}
			set
			{
				System.IntPtr nativeFieldInfoPtr_instance = Singleton<T>.NativeFieldInfoPtr_instance;
				T value2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = value2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr != null)
						{
							value2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								value2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						value2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					value2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_instance, (void*)(&value2));
			}
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x060063E0 RID: 25568 RVA: 0x001C8918 File Offset: 0x001C6B18
		// (set) Token: 0x060063E1 RID: 25569 RVA: 0x0002EF59 File Offset: 0x0002D159
		public unsafe bool Destroyed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Singleton<T>.NativeFieldInfoPtr_Destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Singleton<T>.NativeFieldInfoPtr_Destroyed)) = value;
			}
		}

		// Token: 0x04004417 RID: 17431
		private static readonly System.IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04004418 RID: 17432
		private static readonly System.IntPtr NativeFieldInfoPtr_Destroyed;

		// Token: 0x04004419 RID: 17433
		private static readonly System.IntPtr NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0;

		// Token: 0x0400441A RID: 17434
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x0400441B RID: 17435
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0;

		// Token: 0x0400441C RID: 17436
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400441D RID: 17437
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400441E RID: 17438
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x0400441F RID: 17439
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
